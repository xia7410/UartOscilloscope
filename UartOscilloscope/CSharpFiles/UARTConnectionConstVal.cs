﻿using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace UartOscilloscope.CSharpFiles
{
	class UARTConnectionConstVal
	{
		/// <summary>
		/// 宣告靜態常數
		/// </summary>
		private const int DefaultBaudRate = 9600;                               //	宣告DefaultBaudRate(預設鮑率)常數
		/*	同位位元設定說明：0為不檢查(None),1為奇同位檢察,2為偶同位檢察,3為同位位元恆為1,4為同位位元恆為0 */
		private const Parity DefaultParitySetting = 0;                          //	宣告DefaultParitySetting(預設同位位元設定)常數
	}
}