//=================================================================================================
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

using System.Collections.Generic;

namespace ImageMagick
{
  ///<summary>
  /// Draws a polygon using the current stroke, stroke width, and fill color or texture, using the
  /// specified array of coordinates.
  ///</summary>
  public sealed class DrawablePolygon : IDrawable
  {
    PointDCoordinates _Coordinates;

    void IDrawable.Draw(IDrawingWand wand)
    {
      if (wand != null)
        wand.Polygon(_Coordinates.ToList());
    }

    ///<summary>
    /// Creates a new DrawablePolygon instance.
    ///</summary>
    ///<param name="coordinates">The coordinates.</param>
    public DrawablePolygon(params PointD[] coordinates)
    {
      _Coordinates = new PointDCoordinates(coordinates, 3);
    }

    ///<summary>
    /// Creates a new DrawablePolygon instance.
    ///</summary>
    ///<param name="coordinates">The coordinates.</param>
    public DrawablePolygon(IEnumerable<PointD> coordinates)
    {
      _Coordinates = new PointDCoordinates(coordinates, 3);
    }
  }
}