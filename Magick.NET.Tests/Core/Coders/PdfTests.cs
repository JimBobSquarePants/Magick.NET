﻿//=================================================================================================
// Copyright 2013-2016 Dirk Lemstra <https://magick.codeplex.com/>
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

namespace Magick.NET.Tests.Coders
{
  [TestClass]
  public partial class PdfTests
  {
    private const string _Category = "PdfTests";

    private static void Test_Image(MagickImage image)
    {
      Assert.AreEqual(765, image.Width);
      Assert.AreEqual(361, image.Height);
      Assert.AreEqual(MagickFormat.Ai, image.Format);
    }

    [TestMethod, TestCategory(_Category)]
    public void Test_Format()
    {
      using (MagickImage image = new MagickImage(Files.Coders.CartoonNetworkStudiosLogoAI))
      {
        Test_Image(image);
      }
    }
  }
}