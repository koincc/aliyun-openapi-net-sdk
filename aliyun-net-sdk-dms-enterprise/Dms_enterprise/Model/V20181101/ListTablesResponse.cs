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

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class ListTablesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private long? totalCount;

		private List<ListTables_Table> tableList;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<ListTables_Table> TableList
		{
			get
			{
				return tableList;
			}
			set	
			{
				tableList = value;
			}
		}

		public class ListTables_Table
		{

			private string tableId;

			private string databaseId;

			private string tableName;

			private string tableSchemaName;

			private string engine;

			private string encoding;

			private string tableType;

			private long? numRows;

			private long? storeCapacity;

			private List<string> ownerIdList;

			private List<string> ownerNameList;

			public string TableId
			{
				get
				{
					return tableId;
				}
				set	
				{
					tableId = value;
				}
			}

			public string DatabaseId
			{
				get
				{
					return databaseId;
				}
				set	
				{
					databaseId = value;
				}
			}

			public string TableName
			{
				get
				{
					return tableName;
				}
				set	
				{
					tableName = value;
				}
			}

			public string TableSchemaName
			{
				get
				{
					return tableSchemaName;
				}
				set	
				{
					tableSchemaName = value;
				}
			}

			public string Engine
			{
				get
				{
					return engine;
				}
				set	
				{
					engine = value;
				}
			}

			public string Encoding
			{
				get
				{
					return encoding;
				}
				set	
				{
					encoding = value;
				}
			}

			public string TableType
			{
				get
				{
					return tableType;
				}
				set	
				{
					tableType = value;
				}
			}

			public long? NumRows
			{
				get
				{
					return numRows;
				}
				set	
				{
					numRows = value;
				}
			}

			public long? StoreCapacity
			{
				get
				{
					return storeCapacity;
				}
				set	
				{
					storeCapacity = value;
				}
			}

			public List<string> OwnerIdList
			{
				get
				{
					return ownerIdList;
				}
				set	
				{
					ownerIdList = value;
				}
			}

			public List<string> OwnerNameList
			{
				get
				{
					return ownerNameList;
				}
				set	
				{
					ownerNameList = value;
				}
			}
		}
	}
}
