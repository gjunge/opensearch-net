/* SPDX-License-Identifier: Apache-2.0
*
* The OpenSearch Contributors require contributions made to
* this file be licensed under the Apache-2.0 license or a
* compatible open source license.
*/
/*
* Modifications Copyright OpenSearch Contributors. See
* GitHub history for details.
*
*  Licensed to Elasticsearch B.V. under one or more contributor
*  license agreements. See the NOTICE file distributed with
*  this work for additional information regarding copyright
*  ownership. Elasticsearch B.V. licenses this file to you under
*  the Apache License, Version 2.0 (the "License"); you may
*  not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
* 	http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing,
*  software distributed under the License is distributed on an
*  "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
*  KIND, either express or implied.  See the License for the
*  specific language governing permissions and limitations
*  under the License.
*/

// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenSearch.Net;
using static OpenSearch.Net.HttpMethod;

// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable once CheckNamespace
// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable RedundantExtendsListEntry
namespace OpenSearch.Net.Specification.IngestApi
{
	///<summary>
	/// Ingest APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IOpenSearchLowLevelClient.Ingest"/> property
	/// on <see cref = "IOpenSearchLowLevelClient"/>.
	///</para>
	///</summary>
	public partial class LowLevelIngestNamespace : NamespacedClientProxy
	{
		internal LowLevelIngestNamespace(OpenSearchLowLevelClient client): base(client)
		{
		}

		///<summary>DELETE on /_ingest/pipeline/{id} <para></para></summary>
		///<param name = "id">Pipeline ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse DeletePipeline<TResponse>(string id, DeletePipelineRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(DELETE, Url($"_ingest/pipeline/{id:id}"), null, RequestParams(requestParameters));
		///<summary>DELETE on /_ingest/pipeline/{id} <para></para></summary>
		///<param name = "id">Pipeline ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("ingest.delete_pipeline", "id")]
		public Task<TResponse> DeletePipelineAsync<TResponse>(string id, DeletePipelineRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(DELETE, Url($"_ingest/pipeline/{id:id}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_ingest/pipeline <para></para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetPipeline<TResponse>(GetPipelineRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_ingest/pipeline", null, RequestParams(requestParameters));
		///<summary>GET on /_ingest/pipeline <para></para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("ingest.get_pipeline", "")]
		public Task<TResponse> GetPipelineAsync<TResponse>(GetPipelineRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_ingest/pipeline", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_ingest/pipeline/{id} <para></para></summary>
		///<param name = "id">Comma separated list of pipeline ids. Wildcards supported</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetPipeline<TResponse>(string id, GetPipelineRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"_ingest/pipeline/{id:id}"), null, RequestParams(requestParameters));
		///<summary>GET on /_ingest/pipeline/{id} <para></para></summary>
		///<param name = "id">Comma separated list of pipeline ids. Wildcards supported</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("ingest.get_pipeline", "id")]
		public Task<TResponse> GetPipelineAsync<TResponse>(string id, GetPipelineRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_ingest/pipeline/{id:id}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_ingest/processor/grok <para></para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GrokProcessorPatterns<TResponse>(GrokProcessorPatternsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_ingest/processor/grok", null, RequestParams(requestParameters));
		///<summary>GET on /_ingest/processor/grok <para></para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("ingest.processor_grok", "")]
		public Task<TResponse> GrokProcessorPatternsAsync<TResponse>(GrokProcessorPatternsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_ingest/processor/grok", ctx, null, RequestParams(requestParameters));
		///<summary>PUT on /_ingest/pipeline/{id} <para></para></summary>
		///<param name = "id">Pipeline ID</param>
		///<param name = "body">The ingest definition</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse PutPipeline<TResponse>(string id, PostData body, PutPipelineRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(PUT, Url($"_ingest/pipeline/{id:id}"), body, RequestParams(requestParameters));
		///<summary>PUT on /_ingest/pipeline/{id} <para></para></summary>
		///<param name = "id">Pipeline ID</param>
		///<param name = "body">The ingest definition</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("ingest.put_pipeline", "id, body")]
		public Task<TResponse> PutPipelineAsync<TResponse>(string id, PostData body, PutPipelineRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"_ingest/pipeline/{id:id}"), ctx, body, RequestParams(requestParameters));
		///<summary>POST on /_ingest/pipeline/_simulate <para></para></summary>
		///<param name = "body">The simulate definition</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse SimulatePipeline<TResponse>(PostData body, SimulatePipelineRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(POST, "_ingest/pipeline/_simulate", body, RequestParams(requestParameters));
		///<summary>POST on /_ingest/pipeline/_simulate <para></para></summary>
		///<param name = "body">The simulate definition</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("ingest.simulate", "body")]
		public Task<TResponse> SimulatePipelineAsync<TResponse>(PostData body, SimulatePipelineRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(POST, "_ingest/pipeline/_simulate", ctx, body, RequestParams(requestParameters));
		///<summary>POST on /_ingest/pipeline/{id}/_simulate <para></para></summary>
		///<param name = "id">Pipeline ID</param>
		///<param name = "body">The simulate definition</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse SimulatePipeline<TResponse>(string id, PostData body, SimulatePipelineRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(POST, Url($"_ingest/pipeline/{id:id}/_simulate"), body, RequestParams(requestParameters));
		///<summary>POST on /_ingest/pipeline/{id}/_simulate <para></para></summary>
		///<param name = "id">Pipeline ID</param>
		///<param name = "body">The simulate definition</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("ingest.simulate", "id, body")]
		public Task<TResponse> SimulatePipelineAsync<TResponse>(string id, PostData body, SimulatePipelineRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"_ingest/pipeline/{id:id}/_simulate"), ctx, body, RequestParams(requestParameters));
	}
}
