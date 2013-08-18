﻿//=================================================================================================
// Copyright 2013 Dirk Lemstra <http://magick.codeplex.com/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in 
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================

using ImageMagick;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Magick.NET.Tests
{
	//==============================================================================================
	[TestClass]
	public sealed class ColorProfileTests
	{
		//===========================================================================================
		private const string _Category = "ColorProfile";
		//===========================================================================================
		private static void TestProfile(ColorProfile profile, string name)
		{
			Assert.IsNotNull(profile);
			Assert.AreEqual(name, profile.Name);
			Assert.AreEqual(3144, profile.ToByteArray().Length);
		}
		//===========================================================================================
		[TestMethod, TestCategory(_Category)]
		public void Test_EmbeddedResources()
		{
			ColorProfile sRGB = ColorProfile.SRGB;
			Assert.IsNotNull(sRGB);
			Assert.AreEqual("icc", sRGB.Name);
		}
		//===========================================================================================
		[TestMethod, TestCategory(_Category)]
		public void Test_ICM()
		{
			using (MagickImage image = new MagickImage(Files.SnakewarePNG))
			{
				ColorProfile profile = image.GetColorProfile();
				Assert.IsNull(profile);

				image.AddProfile(new ImageProfile("icm", ColorProfile.SRGB.ToByteArray()));
				TestProfile(image.GetColorProfile(), "icm");
			}
		}
		//===========================================================================================
		[TestMethod, TestCategory(_Category)]
		public void Test_Remove()
		{
			using (MagickImage image = new MagickImage(Files.SnakewarePNG))
			{
				ColorProfile profile = image.GetColorProfile();
				Assert.IsNull(profile);

				image.AddProfile(ColorProfile.SRGB);

				Assert.IsNull(image.GetProfile("icm"));

				profile = image.GetColorProfile();
				Assert.IsNotNull(profile);

				image.RemoveProfile(profile.Name);

				profile = image.GetColorProfile();
				Assert.IsNull(profile);
			}
		}
		//===========================================================================================
		[TestMethod, TestCategory(_Category)]
		public void Test_WithImage()
		{
			using (MagickImage image = new MagickImage(Files.SnakewarePNG))
			{
				ColorProfile profile = image.GetColorProfile();
				Assert.IsNull(profile);

				image.AddProfile(ColorProfile.SRGB);
				TestProfile(image.GetColorProfile(), "icc");
			}
		}
		//===========================================================================================
	}
	//==============================================================================================
}