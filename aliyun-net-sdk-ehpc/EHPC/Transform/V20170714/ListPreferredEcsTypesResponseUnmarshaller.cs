/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.EHPC.Model.V20170714;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Transform.V20170714
{
    public class ListPreferredEcsTypesResponseUnmarshaller
    {
        public static ListPreferredEcsTypesResponse Unmarshall(UnmarshallerContext context)
        {
			ListPreferredEcsTypesResponse listPreferredEcsTypesResponse = new ListPreferredEcsTypesResponse();

			listPreferredEcsTypesResponse.HttpResponse = context.HttpResponse;
			listPreferredEcsTypesResponse.RequestId = context.StringValue("ListPreferredEcsTypes.RequestId");

			List<ListPreferredEcsTypesResponse.ListPreferredEcsTypes_SeriesInfo> listPreferredEcsTypesResponse_series = new List<ListPreferredEcsTypesResponse.ListPreferredEcsTypes_SeriesInfo>();
			for (int i = 0; i < context.Length("ListPreferredEcsTypes.Series.Length"); i++) {
				ListPreferredEcsTypesResponse.ListPreferredEcsTypes_SeriesInfo seriesInfo = new ListPreferredEcsTypesResponse.ListPreferredEcsTypes_SeriesInfo();
				seriesInfo.SeriesId = context.StringValue("ListPreferredEcsTypes.Series["+ i +"].SeriesId");
				seriesInfo.SeriesName = context.StringValue("ListPreferredEcsTypes.Series["+ i +"].SeriesName");

				ListPreferredEcsTypesResponse.ListPreferredEcsTypes_SeriesInfo.ListPreferredEcsTypes_Roles roles = new ListPreferredEcsTypesResponse.ListPreferredEcsTypes_SeriesInfo.ListPreferredEcsTypes_Roles();

				List<string> roles_manager = new List<string>();
				for (int j = 0; j < context.Length("ListPreferredEcsTypes.Series["+ i +"].Roles.Manager.Length"); j++) {
					roles_manager.Add(context.StringValue("ListPreferredEcsTypes.Series["+ i +"].Roles.Manager["+ j +"]"));
				}
				roles.Manager = roles_manager;

				List<string> roles_compute = new List<string>();
				for (int j = 0; j < context.Length("ListPreferredEcsTypes.Series["+ i +"].Roles.Compute.Length"); j++) {
					roles_compute.Add(context.StringValue("ListPreferredEcsTypes.Series["+ i +"].Roles.Compute["+ j +"]"));
				}
				roles.Compute = roles_compute;

				List<string> roles_login = new List<string>();
				for (int j = 0; j < context.Length("ListPreferredEcsTypes.Series["+ i +"].Roles.Login.Length"); j++) {
					roles_login.Add(context.StringValue("ListPreferredEcsTypes.Series["+ i +"].Roles.Login["+ j +"]"));
				}
				roles.Login = roles_login;
				seriesInfo.Roles = roles;

				listPreferredEcsTypesResponse_series.Add(seriesInfo);
			}
			listPreferredEcsTypesResponse.Series = listPreferredEcsTypesResponse_series;
        
			return listPreferredEcsTypesResponse;
        }
    }
}