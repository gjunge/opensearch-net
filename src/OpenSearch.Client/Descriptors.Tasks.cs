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
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using OpenSearch.Net;
using OpenSearch.Net.Utf8Json;
using OpenSearch.Net.Specification.TasksApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace OpenSearch.Client
{
	///<summary>Descriptor for Cancel <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-tasks/</para></summary>
	public partial class CancelTasksDescriptor : RequestDescriptorBase<CancelTasksDescriptor, CancelTasksRequestParameters, ICancelTasksRequest>, ICancelTasksRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TasksCancel;
		///<summary>/_tasks/_cancel</summary>
		public CancelTasksDescriptor(): base()
		{
		}

		///<summary>/_tasks/{task_id}/_cancel</summary>
		///<param name = "taskId">Optional, accepts null</param>
		public CancelTasksDescriptor(TaskId taskId): base(r => r.Optional("task_id", taskId))
		{
		}

		// values part of the url path
		TaskId ICancelTasksRequest.TaskId => Self.RouteValues.Get<TaskId>("task_id");
		///<summary>Cancel the task with specified task id (node_id:task_number)</summary>
		public CancelTasksDescriptor TaskId(TaskId taskId) => Assign(taskId, (a, v) => a.RouteValues.Optional("task_id", v));
		// Request parameters
		///<summary>A comma-separated list of actions that should be cancelled. Leave empty to cancel all.</summary>
		public CancelTasksDescriptor Actions(params string[] actions) => Qs("actions", actions);
		///<summary>A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</summary>
		public CancelTasksDescriptor Nodes(params string[] nodes) => Qs("nodes", nodes);
		///<summary>Cancel tasks with specified parent task id (node_id:task_number). Set to -1 to cancel all.</summary>
		public CancelTasksDescriptor ParentTaskId(string parenttaskid) => Qs("parent_task_id", parenttaskid);
		///<summary>Should the request block until the cancellation of the task and its descendant tasks is completed. Defaults to false</summary>
		public CancelTasksDescriptor WaitForCompletion(bool? waitforcompletion = true) => Qs("wait_for_completion", waitforcompletion);
	}

	///<summary>Descriptor for GetTask <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-tasks/</para></summary>
	public partial class GetTaskDescriptor : RequestDescriptorBase<GetTaskDescriptor, GetTaskRequestParameters, IGetTaskRequest>, IGetTaskRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TasksGetTask;
		///<summary>/_tasks/{task_id}</summary>
		///<param name = "taskId">this parameter is required</param>
		public GetTaskDescriptor(TaskId taskId): base(r => r.Required("task_id", taskId))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected GetTaskDescriptor(): base()
		{
		}

		// values part of the url path
		TaskId IGetTaskRequest.TaskId => Self.RouteValues.Get<TaskId>("task_id");
		// Request parameters
		///<summary>Explicit operation timeout</summary>
		public GetTaskDescriptor Timeout(Time timeout) => Qs("timeout", timeout);
		///<summary>Wait for the matching tasks to complete (default: false)</summary>
		public GetTaskDescriptor WaitForCompletion(bool? waitforcompletion = true) => Qs("wait_for_completion", waitforcompletion);
	}

	///<summary>Descriptor for List <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-tasks/</para></summary>
	public partial class ListTasksDescriptor : RequestDescriptorBase<ListTasksDescriptor, ListTasksRequestParameters, IListTasksRequest>, IListTasksRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TasksList;
		// values part of the url path
		// Request parameters
		///<summary>A comma-separated list of actions that should be returned. Leave empty to return all.</summary>
		public ListTasksDescriptor Actions(params string[] actions) => Qs("actions", actions);
		///<summary>Return detailed task information (default: false)</summary>
		public ListTasksDescriptor Detailed(bool? detailed = true) => Qs("detailed", detailed);
		///<summary>Group tasks by nodes or parent/child relationships</summary>
		public ListTasksDescriptor GroupBy(GroupBy? groupby) => Qs("group_by", groupby);
		///<summary>A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</summary>
		public ListTasksDescriptor Nodes(params string[] nodes) => Qs("nodes", nodes);
		///<summary>Return tasks with specified parent task id (node_id:task_number). Set to -1 to return all.</summary>
		public ListTasksDescriptor ParentTaskId(string parenttaskid) => Qs("parent_task_id", parenttaskid);
		///<summary>Explicit operation timeout</summary>
		public ListTasksDescriptor Timeout(Time timeout) => Qs("timeout", timeout);
		///<summary>Wait for the matching tasks to complete (default: false)</summary>
		public ListTasksDescriptor WaitForCompletion(bool? waitforcompletion = true) => Qs("wait_for_completion", waitforcompletion);
	}
}
