//-----------------------------------------------------------------------
// <copyright file="SequentialGuidType.cs" company="Jeremy H. Todd">
//     Copyright © Jeremy H. Todd 2011
// </copyright>
//-----------------------------------------------------------------------
namespace SequentialGuid
{
  using System;

  /// <summary>
  /// Describes the type of a sequential GUID value.
  /// </summary>
  public enum SequentialGuidType
  {
    /// <summary>
    /// The GUID should be sequential when formatted using the
    /// <see cref="Guid.ToString()" /> method.
    /// </summary>
    SequentialAsString,

    /// <summary>
    /// The GUID should be sequential when formatted using the
    /// <see cref="Guid.ToByteArray" /> method.
    /// </summary>
    SequentialAsBinary,

    /// <summary>
    /// The sequential portion of the GUID should be located at the end
    /// of the Data4 block.
    /// </summary>
    SequentialAtEnd
  }
}