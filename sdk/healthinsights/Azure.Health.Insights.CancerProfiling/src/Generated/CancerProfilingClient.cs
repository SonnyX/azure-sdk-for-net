// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Health.Insights.CancerProfiling
{
    // Data plane generated client.
    /// <summary> The CancerProfiling service client. </summary>
    public partial class CancerProfilingClient
    {
        private const string AuthorizationHeader = "Ocp-Apim-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of CancerProfilingClient for mocking. </summary>
        protected CancerProfilingClient()
        {
        }

        /// <summary> Initializes a new instance of CancerProfilingClient. </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoints (protocol and hostname, for example: https://westus2.api.cognitive.microsoft.com). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public CancerProfilingClient(Uri endpoint, AzureKeyCredential credential) : this(endpoint, credential, new CancerProfilingClientOptions())
        {
        }

        /// <summary> Initializes a new instance of CancerProfilingClient. </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoints (protocol and hostname, for example: https://westus2.api.cognitive.microsoft.com). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public CancerProfilingClient(Uri endpoint, AzureKeyCredential credential, CancerProfilingClientOptions options)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            options ??= new CancerProfilingClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Create Onco Phenotype job. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="oncoPhenotypeData"> The body of the Onco Phenotype request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="oncoPhenotypeData"/> is null. </exception>
        /// <remarks> Creates an Onco Phenotype job with the given request body. </remarks>
        /// <include file="Docs/CancerProfilingClient.xml" path="doc/members/member[@name='InferCancerProfileAsync(WaitUntil,OncoPhenotypeData,CancellationToken)']/*" />
        public virtual async Task<Operation<OncoPhenotypeResults>> InferCancerProfileAsync(WaitUntil waitUntil, OncoPhenotypeData oncoPhenotypeData, CancellationToken cancellationToken = default)
        {
            if (oncoPhenotypeData == null)
            {
                throw new ArgumentNullException(nameof(oncoPhenotypeData));
            }

            RequestContext context = FromCancellationToken(cancellationToken);
            using RequestContent content = oncoPhenotypeData.ToRequestContent();
            Operation<BinaryData> response = await InferCancerProfileAsync(waitUntil, content, context).ConfigureAwait(false);
            return ProtocolOperationHelpers.Convert(response, FetchOncoPhenotypeResultsFromOncoPhenotypeResult, ClientDiagnostics, "CancerProfilingClient.InferCancerProfile");
        }

        /// <summary> Create Onco Phenotype job. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="oncoPhenotypeData"> The body of the Onco Phenotype request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="oncoPhenotypeData"/> is null. </exception>
        /// <remarks> Creates an Onco Phenotype job with the given request body. </remarks>
        /// <include file="Docs/CancerProfilingClient.xml" path="doc/members/member[@name='InferCancerProfile(WaitUntil,OncoPhenotypeData,CancellationToken)']/*" />
        public virtual Operation<OncoPhenotypeResults> InferCancerProfile(WaitUntil waitUntil, OncoPhenotypeData oncoPhenotypeData, CancellationToken cancellationToken = default)
        {
            if (oncoPhenotypeData == null)
            {
                throw new ArgumentNullException(nameof(oncoPhenotypeData));
            }

            RequestContext context = FromCancellationToken(cancellationToken);
            using RequestContent content = oncoPhenotypeData.ToRequestContent();
            Operation<BinaryData> response = InferCancerProfile(waitUntil, content, context);
            return ProtocolOperationHelpers.Convert(response, FetchOncoPhenotypeResultsFromOncoPhenotypeResult, ClientDiagnostics, "CancerProfilingClient.InferCancerProfile");
        }

        /// <summary>
        /// [Protocol Method] Create Onco Phenotype job
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="InferCancerProfileAsync(WaitUntil,OncoPhenotypeData,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation"/> representing an asynchronous operation on the service. </returns>
        /// <include file="Docs/CancerProfilingClient.xml" path="doc/members/member[@name='InferCancerProfileAsync(WaitUntil,RequestContent,RequestContext)']/*" />
        public virtual async Task<Operation<BinaryData>> InferCancerProfileAsync(WaitUntil waitUntil, RequestContent content, RequestContext context = null)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = ClientDiagnostics.CreateScope("CancerProfilingClient.InferCancerProfile");
            scope.Start();
            try
            {
                using HttpMessage message = CreateInferCancerProfileRequest(content, context);
                return await ProtocolOperationHelpers.ProcessMessageAsync(_pipeline, message, ClientDiagnostics, "CancerProfilingClient.InferCancerProfile", OperationFinalStateVia.OperationLocation, context, waitUntil).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Create Onco Phenotype job
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="InferCancerProfile(WaitUntil,OncoPhenotypeData,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation"/> representing an asynchronous operation on the service. </returns>
        /// <include file="Docs/CancerProfilingClient.xml" path="doc/members/member[@name='InferCancerProfile(WaitUntil,RequestContent,RequestContext)']/*" />
        public virtual Operation<BinaryData> InferCancerProfile(WaitUntil waitUntil, RequestContent content, RequestContext context = null)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = ClientDiagnostics.CreateScope("CancerProfilingClient.InferCancerProfile");
            scope.Start();
            try
            {
                using HttpMessage message = CreateInferCancerProfileRequest(content, context);
                return ProtocolOperationHelpers.ProcessMessage(_pipeline, message, ClientDiagnostics, "CancerProfilingClient.InferCancerProfile", OperationFinalStateVia.OperationLocation, context, waitUntil);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateInferCancerProfileRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200202);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/healthinsights", false);
            uri.AppendPath("/oncophenotype/jobs", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Repeatability-Request-ID", Guid.NewGuid());
            request.Headers.Add("Repeatability-First-Sent", DateTimeOffset.Now, "R");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        private static RequestContext DefaultRequestContext = new RequestContext();
        internal static RequestContext FromCancellationToken(CancellationToken cancellationToken = default)
        {
            if (!cancellationToken.CanBeCanceled)
            {
                return DefaultRequestContext;
            }

            return new RequestContext() { CancellationToken = cancellationToken };
        }

        private static ResponseClassifier _responseClassifier200202;
        private static ResponseClassifier ResponseClassifier200202 => _responseClassifier200202 ??= new StatusCodeClassifier(stackalloc ushort[] { 200, 202 });

        private OncoPhenotypeResults FetchOncoPhenotypeResultsFromOncoPhenotypeResult(Response response)
        {
            var resultJsonElement = JsonDocument.Parse(response.Content).RootElement.GetProperty("results");
            return OncoPhenotypeResults.DeserializeOncoPhenotypeResults(resultJsonElement);
        }
    }
}
