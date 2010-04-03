﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using SyncSharp.DataModel;

namespace SyncSharp.Storage
{
	static class Utility
	{
		public static String computeMyHash(FileUnit myFile)
		{
			FileStream myFileStream = new FileStream(myFile.AbsolutePath, FileMode.Open, FileAccess.Read);
			String strHash = "";
			if (myFile.Size < 30000)
			{
				byte[] tmpHash = new SHA1Managed().ComputeHash(myFileStream);
				strHash = BitConverter.ToString(tmpHash, 0).Replace("-", "");
			}
			else
			{
				byte[] fileHeader = new byte[30000];
				myFileStream.Read(fileHeader, 0, 30000);
				byte[] tmpHash = new SHA1Managed().ComputeHash(fileHeader);
				strHash = BitConverter.ToString(tmpHash, 0).Replace("-", "");
			}
			myFileStream.Dispose();
			return strHash;
		}
	}
}