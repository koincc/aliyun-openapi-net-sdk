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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20180120;

namespace Aliyun.Acs.Iot.Model.V20180120
{
    public class CreateOTAStaticUpgradeJobRequest : RpcAcsRequest<CreateOTAStaticUpgradeJobResponse>
    {
        public CreateOTAStaticUpgradeJobRequest()
            : base("Iot", "2018-01-20", "CreateOTAStaticUpgradeJob", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private int? retryCount;

		private int? timeoutInMinutes;

		private string iotInstanceId;

		private string targetSelection;

		private string grayPercent;

		private string firmwareId;

		private string productKey;

		private int? retryInterval;

		private List<string> srcVersions = new List<string>(){ };

		private long? scheduleTime;

		private int? maximumPerMinute;

		private List<string> targetDeviceNames = new List<string>(){ };

		public int? RetryCount
		{
			get
			{
				return retryCount;
			}
			set	
			{
				retryCount = value;
				DictionaryUtil.Add(QueryParameters, "RetryCount", value.ToString());
			}
		}

		public int? TimeoutInMinutes
		{
			get
			{
				return timeoutInMinutes;
			}
			set	
			{
				timeoutInMinutes = value;
				DictionaryUtil.Add(QueryParameters, "TimeoutInMinutes", value.ToString());
			}
		}

		public string IotInstanceId
		{
			get
			{
				return iotInstanceId;
			}
			set	
			{
				iotInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "IotInstanceId", value);
			}
		}

		public string TargetSelection
		{
			get
			{
				return targetSelection;
			}
			set	
			{
				targetSelection = value;
				DictionaryUtil.Add(QueryParameters, "TargetSelection", value);
			}
		}

		public string GrayPercent
		{
			get
			{
				return grayPercent;
			}
			set	
			{
				grayPercent = value;
				DictionaryUtil.Add(QueryParameters, "GrayPercent", value);
			}
		}

		public string FirmwareId
		{
			get
			{
				return firmwareId;
			}
			set	
			{
				firmwareId = value;
				DictionaryUtil.Add(QueryParameters, "FirmwareId", value);
			}
		}

		public string ProductKey
		{
			get
			{
				return productKey;
			}
			set	
			{
				productKey = value;
				DictionaryUtil.Add(QueryParameters, "ProductKey", value);
			}
		}

		public int? RetryInterval
		{
			get
			{
				return retryInterval;
			}
			set	
			{
				retryInterval = value;
				DictionaryUtil.Add(QueryParameters, "RetryInterval", value.ToString());
			}
		}

		public List<string> SrcVersions
		{
			get
			{
				return srcVersions;
			}

			set
			{
				srcVersions = value;
				for (int i = 0; i < srcVersions.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SrcVersion." + (i + 1) , srcVersions[i]);
				}
			}
		}

		public long? ScheduleTime
		{
			get
			{
				return scheduleTime;
			}
			set	
			{
				scheduleTime = value;
				DictionaryUtil.Add(QueryParameters, "ScheduleTime", value.ToString());
			}
		}

		public int? MaximumPerMinute
		{
			get
			{
				return maximumPerMinute;
			}
			set	
			{
				maximumPerMinute = value;
				DictionaryUtil.Add(QueryParameters, "MaximumPerMinute", value.ToString());
			}
		}

		public List<string> TargetDeviceNames
		{
			get
			{
				return targetDeviceNames;
			}

			set
			{
				targetDeviceNames = value;
				for (int i = 0; i < targetDeviceNames.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"TargetDeviceName." + (i + 1) , targetDeviceNames[i]);
				}
			}
		}

        public override CreateOTAStaticUpgradeJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateOTAStaticUpgradeJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
