﻿/* =============================================================================*\
*
* Filename: NetUtilPeopertyAttribute
* Description: 
*
* Version: 1.0
* Created: 2017/10/16 13:41:51(UTC+8:00)
* Compiler: Visual Studio 2017
* 
* Author: zsh2401
* Company: I am free man
*
\* =============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutumnBox.GUI.NetUtil
{
    [AttributeUsage(AttributeTargets.Class)]
    public class NetUnitPropertyAttribute : Attribute
    {
        public bool UseLocalApi { get; set; } = false;
        public bool MustAddFininshedEventHandler { get; set; } = false;
    }
}