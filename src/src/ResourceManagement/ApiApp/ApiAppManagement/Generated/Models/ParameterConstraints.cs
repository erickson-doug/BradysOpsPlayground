// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.ApiApps.Models;

namespace Microsoft.Azure.Management.ApiApps.Models
{
    public partial class ParameterConstraints
    {
        private IList<string> _allowedValues;
        
        /// <summary>
        /// Optional. Gets or sets allowed values
        /// </summary>
        public IList<string> AllowedValues
        {
            get { return this._allowedValues; }
            set { this._allowedValues = value; }
        }
        
        private string _containsCharacters;
        
        /// <summary>
        /// Optional. Gets or sets contains characters
        /// </summary>
        public string ContainsCharacters
        {
            get { return this._containsCharacters; }
            set { this._containsCharacters = value; }
        }
        
        private bool _hasDigit;
        
        /// <summary>
        /// Optional. Gets or sets has digit
        /// </summary>
        public bool HasDigit
        {
            get { return this._hasDigit; }
            set { this._hasDigit = value; }
        }
        
        private bool _hasLetter;
        
        /// <summary>
        /// Optional. Gets or sets has letter
        /// </summary>
        public bool HasLetter
        {
            get { return this._hasLetter; }
            set { this._hasLetter = value; }
        }
        
        private bool _hasPunctuation;
        
        /// <summary>
        /// Optional. Gets or sets has punctuation
        /// </summary>
        public bool HasPunctuation
        {
            get { return this._hasPunctuation; }
            set { this._hasPunctuation = value; }
        }
        
        private bool _hidden;
        
        /// <summary>
        /// Optional. Gets or sets hidden
        /// </summary>
        public bool Hidden
        {
            get { return this._hidden; }
            set { this._hidden = value; }
        }
        
        private LengthConstraint _length;
        
        /// <summary>
        /// Optional. Gets or sets length
        /// </summary>
        public LengthConstraint Length
        {
            get { return this._length; }
            set { this._length = value; }
        }
        
        private string _notContainsCharacters;
        
        /// <summary>
        /// Optional. Gets or sets not contains characters
        /// </summary>
        public string NotContainsCharacters
        {
            get { return this._notContainsCharacters; }
            set { this._notContainsCharacters = value; }
        }
        
        private bool _numeric;
        
        /// <summary>
        /// Optional. Gets or sets numeric
        /// </summary>
        public bool Numeric
        {
            get { return this._numeric; }
            set { this._numeric = value; }
        }
        
        private RangeConstraint _range;
        
        /// <summary>
        /// Optional. Gets or sets range
        /// </summary>
        public RangeConstraint Range
        {
            get { return this._range; }
            set { this._range = value; }
        }
        
        private bool _required;
        
        /// <summary>
        /// Optional. Gets or sets required
        /// </summary>
        public bool Required
        {
            get { return this._required; }
            set { this._required = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ParameterConstraints class.
        /// </summary>
        public ParameterConstraints()
        {
            this.AllowedValues = new LazyList<string>();
        }
    }
}
