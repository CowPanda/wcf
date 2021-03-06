// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace System.ServiceModel.Security.Tokens
{
    public class UserNameSecurityTokenParameters : SecurityTokenParameters
    {
        protected UserNameSecurityTokenParameters(UserNameSecurityTokenParameters other)
            : base(other)
        {
            base.RequireDerivedKeys = false;
        }

        public UserNameSecurityTokenParameters()
            : base()
        {
            base.RequireDerivedKeys = false;
        }

        internal protected override bool HasAsymmetricKey { get { return false; } }
        internal protected override bool SupportsClientAuthentication { get { return true; } }
        internal protected override bool SupportsServerAuthentication { get { return false; } }
        internal protected override bool SupportsClientWindowsIdentity { get { return true; } }

        protected override SecurityTokenParameters CloneCore()
        {
            return new UserNameSecurityTokenParameters(this);
        }
    }
}
