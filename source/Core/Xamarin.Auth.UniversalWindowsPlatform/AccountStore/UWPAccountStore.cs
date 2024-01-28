﻿//
//  Copyright 2013, Xamarin Inc.
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

using Windows.Security.Cryptography;
using Windows.Storage;

namespace Xamarin.Auth.WindowsUWP
{
    internal partial class UWPAccountStore : AccountStore
    {
        public override IEnumerable<Account> FindAccountsForService(string serviceId)
        {
            return FindAccountsForServiceAsync(serviceId).Result;
        }

        public override void Save(Account account, string serviceId)
        {
            Task t  = SaveAsync(account, serviceId);

            return;
        }

        public override void Delete(Account account, string serviceId)
        {
            Task t = DeleteAsync(account, serviceId);

            return;
        }
    }
}
