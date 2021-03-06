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

namespace ImageMagick
{
  ///<summary>
  /// Specifies the virtual pixel methods.
  ///</summary>
  public enum VirtualPixelMethod
  {

    /// <summary>
    /// Undefined
    /// </summary>
    Undefined,

    /// <summary>
    /// Background
    /// </summary>
    Background,

    /// <summary>
    /// Dither
    /// </summary>
    Dither,

    /// <summary>
    /// Edge
    /// </summary>
    Edge,

    /// <summary>
    /// Mirror
    /// </summary>
    Mirror,

    /// <summary>
    /// Random
    /// </summary>
    Random,

    /// <summary>
    /// Tile
    /// </summary>
    Tile,

    /// <summary>
    /// Transparent
    /// </summary>
    Transparent,

    /// <summary>
    /// Mask
    /// </summary>
    Mask,

    /// <summary>
    /// Black
    /// </summary>
    Black,

    /// <summary>
    /// Gray
    /// </summary>
    Gray,

    /// <summary>
    /// White
    /// </summary>
    White,

    /// <summary>
    /// HorizontalTile
    /// </summary>
    HorizontalTile,

    /// <summary>
    /// VerticalTile
    /// </summary>
    VerticalTile,

    /// <summary>
    /// HorizontalTileEdge
    /// </summary>
    HorizontalTileEdge,

    /// <summary>
    /// VerticalTileEdge
    /// </summary>
    VerticalTileEdge,

    /// <summary>
    /// CheckerTile
    /// </summary>
    CheckerTile
  }
}