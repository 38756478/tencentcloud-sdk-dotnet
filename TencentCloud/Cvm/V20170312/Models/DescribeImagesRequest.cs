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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeImagesRequest : AbstractModel
    {
        
        /// <summary>
        /// 镜像ID列表 。镜像ID如：`img-gvbnzy6f`。array型参数的格式可以参考[API简介](https://cloud.tencent.com/document/api/213/15688)。镜像ID可以通过如下方式获取：<br><li>通过[DescribeImages](https://cloud.tencent.com/document/api/213/15715)接口返回的`ImageId`获取。<br><li>通过[镜像控制台](https://console.cloud.tencent.com/cvm/image)获取。
        /// </summary>
        [JsonProperty("ImageIds")]
        public string[] ImageIds{ get; set; }

        /// <summary>
        /// 过滤条件，每次请求的`Filters`的上限为0，`Filters.Values`的上限为5。参数不可以同时指定`ImageIds`和`Filters`。详细的过滤条件如下：
        /// <li> image-id - String - 是否必填： 否 - （过滤条件）按照镜像ID进行过滤</li>
        /// <li> image-type - String - 是否必填： 否 - （过滤条件）按照镜像类型进行过滤。取值范围：详见[镜像类型](https://cloud.tencent.com/document/product/213/9452#image_type)。</li>
        /// <li> image-state - String - 是否必填： 否 - （过滤条件）按照镜像状态进行过滤。取值范围：详见[镜像状态](https://cloud.tencent.com/document/product/213/9452#image_state)。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。关于Offset详见[API简介](/document/api/213/568#.E8.BE.93.E5.85.A5.E5.8F.82.E6.95.B0.E4.B8.8E.E8.BF.94.E5.9B.9E.E5.8F.82.E6.95.B0.E9.87.8A.E4.B9.89)。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 数量限制，默认为20，最大值为100。关于Limit详见[API简介](/document/api/213/568#.E8.BE.93.E5.85.A5.E5.8F.82.E6.95.B0.E4.B8.8E.E8.BF.94.E5.9B.9E.E5.8F.82.E6.95.B0.E9.87.8A.E4.B9.89)。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 实例类型，如 `S1.SMALL1`
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ImageIds.", this.ImageIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
        }
    }
}

