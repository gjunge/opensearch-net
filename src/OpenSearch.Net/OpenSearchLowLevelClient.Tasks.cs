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
namespace OpenSearch.Net.Specification.TasksApi
{
	///<summary>
	/// Tasks APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IOpenSearchLowLevelClient.Tasks"/> property
	/// on <see cref = "IOpenSearchLowLevelClient"/>.
	///</para>
	///</summary>
	public partial class LowLevelTasksNamespace : NamespacedClientProxy
	{
		internal LowLevelTasksNamespace(OpenSearchLowLevelClient client): base(client)
		{
		}

		///<summary>POST on /_tasks/_cancel <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-tasks/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the OpenSearch server, this functionality is Experimental and may be changed or removed completely in a future release. OpenSearch will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		public TResponse Cancel<TResponse>(CancelTasksRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(POST, "_tasks/_cancel", null, RequestParams(requestParameters));
		///<summary>POST on /_tasks/_cancel <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-tasks/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the OpenSearch server, this functionality is Experimental and may be changed or removed completely in a future release. OpenSearch will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		[MapsApi("tasks.cancel", "")]
		public Task<TResponse> CancelAsync<TResponse>(CancelTasksRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(POST, "_tasks/_cancel", ctx, null, RequestParams(requestParameters));
		///<summary>POST on /_tasks/{task_id}/_cancel <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-tasks/</para></summary>
		///<param name = "taskId">Cancel the task with specified task id (node_id:task_number)</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the OpenSearch server, this functionality is Experimental and may be changed or removed completely in a future release. OpenSearch will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		public TResponse Cancel<TResponse>(string taskId, CancelTasksRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(POST, Url($"_tasks/{taskId:taskId}/_cancel"), null, RequestParams(requestParameters));
		///<summary>POST on /_tasks/{task_id}/_cancel <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-tasks/</para></summary>
		///<param name = "taskId">Cancel the task with specified task id (node_id:task_number)</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the OpenSearch server, this functionality is Experimental and may be changed or removed completely in a future release. OpenSearch will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		[MapsApi("tasks.cancel", "task_id")]
		public Task<TResponse> CancelAsync<TResponse>(string taskId, CancelTasksRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"_tasks/{taskId:taskId}/_cancel"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_tasks/{task_id} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-tasks/</para></summary>
		///<param name = "taskId">Return the task with specified id (node_id:task_number)</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the OpenSearch server, this functionality is Experimental and may be changed or removed completely in a future release. OpenSearch will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		public TResponse GetTask<TResponse>(string taskId, GetTaskRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"_tasks/{taskId:taskId}"), null, RequestParams(requestParameters));
		///<summary>GET on /_tasks/{task_id} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-tasks/</para></summary>
		///<param name = "taskId">Return the task with specified id (node_id:task_number)</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the OpenSearch server, this functionality is Experimental and may be changed or removed completely in a future release. OpenSearch will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		[MapsApi("tasks.get", "task_id")]
		public Task<TResponse> GetTaskAsync<TResponse>(string taskId, GetTaskRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_tasks/{taskId:taskId}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_tasks <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-tasks/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the OpenSearch server, this functionality is Experimental and may be changed or removed completely in a future release. OpenSearch will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		public TResponse List<TResponse>(ListTasksRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_tasks", null, RequestParams(requestParameters));
		///<summary>GET on /_tasks <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-tasks/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the OpenSearch server, this functionality is Experimental and may be changed or removed completely in a future release. OpenSearch will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		[MapsApi("tasks.list", "")]
		public Task<TResponse> ListAsync<TResponse>(ListTasksRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_tasks", ctx, null, RequestParams(requestParameters));
	}
}
