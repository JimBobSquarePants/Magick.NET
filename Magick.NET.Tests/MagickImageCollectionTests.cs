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

using System.Drawing;
using System.Drawing.Imaging;
using ImageMagick;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Magick.NET.Tests
{
  public partial class MagickImageCollectionTests
  {
    [TestMethod, TestCategory(_Category)]
    public void Test_ToBitmap()
    {
      using (MagickImageCollection collection = new MagickImageCollection(Files.RoseSparkleGIF))
      {
        Assert.AreEqual(3, collection.Count);

        Bitmap bitmap = collection.ToBitmap();
        Assert.IsNotNull(bitmap);
        Assert.AreEqual(3, bitmap.GetFrameCount(FrameDimension.Page));
      }
    }
  }
}

