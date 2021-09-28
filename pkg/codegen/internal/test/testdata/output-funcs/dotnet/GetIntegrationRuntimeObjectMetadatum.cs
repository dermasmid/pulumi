// *** WARNING: this file was generated by test. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Mypkg
{
    public static class GetIntegrationRuntimeObjectMetadatum
    {
        /// <summary>
        /// Another failing example. A list of SSIS object metadata.
        /// API Version: 2018-06-01.
        /// </summary>
        public static Task<GetIntegrationRuntimeObjectMetadatumResult> InvokeAsync(GetIntegrationRuntimeObjectMetadatumArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetIntegrationRuntimeObjectMetadatumResult>("mypkg::getIntegrationRuntimeObjectMetadatum", args ?? new GetIntegrationRuntimeObjectMetadatumArgs(), options.WithVersion());
    }


    public sealed class GetIntegrationRuntimeObjectMetadatumArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The factory name.
        /// </summary>
        [Input("factoryName", required: true)]
        public string FactoryName { get; set; } = null!;

        /// <summary>
        /// The integration runtime name.
        /// </summary>
        [Input("integrationRuntimeName", required: true)]
        public string IntegrationRuntimeName { get; set; } = null!;

        /// <summary>
        /// Metadata path.
        /// </summary>
        [Input("metadataPath")]
        public string? MetadataPath { get; set; }

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetIntegrationRuntimeObjectMetadatumArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetIntegrationRuntimeObjectMetadatumResult
    {
        /// <summary>
        /// The link to the next page of results, if any remaining results exist.
        /// </summary>
        public readonly string? NextLink;
        /// <summary>
        /// List of SSIS object metadata.
        /// </summary>
        public readonly ImmutableArray<object> Value;

        [OutputConstructor]
        private GetIntegrationRuntimeObjectMetadatumResult(
            string? nextLink,

            ImmutableArray<object> value)
        {
            NextLink = nextLink;
            Value = value;
        }
    }
}