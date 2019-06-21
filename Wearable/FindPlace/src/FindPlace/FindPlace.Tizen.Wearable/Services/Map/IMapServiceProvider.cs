/*
 * Copyright (c) 2019 Samsung Electronics Co., Ltd. All rights reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using Tizen.Maps;

namespace FindPlace.Interfaces
{
    /// <summary>
    /// Provides methods to get map service.
    /// </summary>
    public interface IMapServiceProvider
    {
        #region methods

        /// <summary>
        /// Gets MapService class instance.
        /// </summary>
        /// <returns>MapService class instance.</returns>
        MapService GetService();

        #endregion
    }
}
