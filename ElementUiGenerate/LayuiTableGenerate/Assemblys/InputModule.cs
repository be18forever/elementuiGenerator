﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LayuiTableGenerate.Classes;
using ServiceStack;

namespace LayuiTableGenerate.Assemblys
{
    public class InputModule
    {
        public InputModule(string modelName,string showName,string frontLabelName="")
        {

            _modelName = modelName;
            _showName = showName;
            _frontLabelName = frontLabelName;
            _tableName = modelName.Split('.')[1];
        }
        private string _modelName;
        private string _showName;
        private string _value;
        private string _frontLabelName;
        private string _tableName;
        public string Value
        {
            get
            {
                _value = @"<el-form-item prop='"+ _tableName.ToFirstLetterLower() + "' label='" + _frontLabelName + @"'>
                        <el-input placeholder='" + _showName + @"' v-model='"+ _modelName + @"'></el-input>
                    </el-form-item>";
                return _value;

            }
        }
    }
}
