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

using System;

namespace ImageMagick
{
  ///<summary>
  /// Encapsulates a matrix of doubles.
  ///</summary>
  public abstract partial class DoubleMatrix
  {
    private double[] _Values;

    private INativeInstance CreateNativeInstance()
    {
      return new NativeDoubleMatrix(_Values, Order);
    }

    private int GetIndex(int x, int y)
    {
      Throw.IfOutOfRange(nameof(x), x, Order);
      Throw.IfOutOfRange(nameof(y), y, Order);

      return (y * Order) + x;
    }

    /// <summary>
    /// Creates a new ConvolveMatrix instance with the specified order.
    /// </summary>
    /// <param name="order"></param>
    /// <param name="values"></param>
    protected DoubleMatrix(int order, double[] values)
    {
      Order = order;

      _Values = new double[Order * Order];
      if (values != null)
      {
        Throw.IfFalse(nameof(values), (Order * Order) == values.Length, "Invalid number of values specified");
        Array.Copy(values, _Values, _Values.Length);
      }
    }

    ///<summary>
    /// Get or set the value at the specified x/y position.
    ///</summary>
    public double this[int x, int y]
    {
      get
      {
        return GetValue(x, y);
      }
      set
      {
        SetValue(x, y, value);
      }
    }

    ///<summary>
    /// Returns the order of the matrix.
    ///</summary>
    public int Order
    {
      get;
      private set;
    }

    ///<summary>
    /// Returns the value at the specified x/y position.
    ///</summary>
    ///<param name="x">The x position</param>
    ///<param name="y">The y position</param>
    public double GetValue(int x, int y)
    {
      return _Values[GetIndex(x, y)];
    }

    ///<summary>
    /// Set the column at the specified x position.
    ///</summary>
    ///<param name="x">The x position</param>
    ///<param name="values">The values</param>
    public void SetColumn(int x, params double[] values)
    {
      Throw.IfOutOfRange(nameof(x), x, Order);
      Throw.IfNull(nameof(values), values);
      Throw.IfTrue(nameof(values), values.Length != Order, "Invalid length");

      for (int y = 0; y < Order; y++)
      {
        SetValue(x, y, values[y]);
      }
    }

    ///<summary>
    /// Set the row at the specified y position.
    ///</summary>
    ///<param name="y">The y position</param>
    ///<param name="values">The values</param>
    public void SetRow(int y, params double[] values)
    {
      Throw.IfOutOfRange(nameof(y), y, Order);
      Throw.IfNull(nameof(values), values);
      Throw.IfTrue(nameof(values), values.Length != Order, "Invalid length");

      for (int x = 0; x < Order; x++)
      {
        SetValue(x, y, values[x]);
      }
    }

    ///<summary>
    /// Set the value at the specified x/y position.
    ///</summary>
    ///<param name="x">The x position</param>
    ///<param name="y">The y position</param>
    ///<param name="value">The value</param>
    public void SetValue(int x, int y, double value)
    {
      _Values[GetIndex(x, y)] = value;
    }

    ///<summary>
    /// Returns a string that represents the current DoubleMatrix.
    ///</summary>
    public double[] ToArray()
    {
      return _Values;
    }
  }
}