﻿// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using System.Collections.Generic;
using ADotNet.Clients;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets.Tasks;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets.Tasks.SetupDotNetTaskV1s;

namespace CashOverflow.Infrastructure.Build
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var githubPipeline = new GithubPipeline
            {
                Name = "Build & Test CashOverflow",

                OnEvents = new Events
                {
                    Push = new PushEvent
                    {
                        Branches = new string[] { "master" }
                    },

                    PullRequest = new PullRequestEvent
                    {
                        Branches = new string[] { "master" }
                    }
                },

                Jobs = new Jobs
                {
                    Build = new BuildJob
                    {
                        RunsOn = BuildMachines.WindowsLatest,

                        Steps = new List<GithubTask>
                        {
                            new CheckoutTaskV2
                            {
                                Name = "Checking out"
                            },

                            new SetupDotNetTaskV1
                            {
                                Name= "Installing .NET",

                                TargetDotNetVersion = new TargetDotNetVersion
                                {
                                    DotNetVersion = "7.0.201"
                                }
                            },

                            new RestoreTask
                            {
                                Name = "Restoring packages"
                            },

                            new DotNetBuildTask
                            {
                                Name = "Building project"
                            },

                            new TestTask
                            {
                                Name = "Running tests"
                            }
                        }
                    }
                }
            };


            var adotnetClient = new ADotNetClient();

            adotnetClient.SerializeAndWriteToFile(
                githubPipeline,
                path: "../../../../.github/workflows/build.yml");
        }
    }
}
