
// Copyright (C) 2015 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_PIXEL_PACK_BUFFER symbol.
		/// </summary>
		[AliasOf("GL_PIXEL_PACK_BUFFER_ARB")]
		[AliasOf("GL_PIXEL_PACK_BUFFER_EXT")]
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int PIXEL_PACK_BUFFER = 0x88EB;

		/// <summary>
		/// Value of GL_PIXEL_UNPACK_BUFFER symbol.
		/// </summary>
		[AliasOf("GL_PIXEL_UNPACK_BUFFER_ARB")]
		[AliasOf("GL_PIXEL_UNPACK_BUFFER_EXT")]
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int PIXEL_UNPACK_BUFFER = 0x88EC;

		/// <summary>
		/// Gl.Get: data returns a single value, the name of the buffer object currently bound to the target Gl.PIXEL_PACK_BUFFER. 
		/// If no buffer object is bound to this target, 0 is returned. The initial value is 0. See Gl.BindBuffer.
		/// </summary>
		[AliasOf("GL_PIXEL_PACK_BUFFER_BINDING_ARB")]
		[AliasOf("GL_PIXEL_PACK_BUFFER_BINDING_EXT")]
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int PIXEL_PACK_BUFFER_BINDING = 0x88ED;

		/// <summary>
		/// Gl.Get: data returns a single value, the name of the buffer object currently bound to the target Gl.PIXEL_UNPACK_BUFFER. 
		/// If no buffer object is bound to this target, 0 is returned. The initial value is 0. See Gl.BindBuffer.
		/// </summary>
		[AliasOf("GL_PIXEL_UNPACK_BUFFER_BINDING_ARB")]
		[AliasOf("GL_PIXEL_UNPACK_BUFFER_BINDING_EXT")]
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int PIXEL_UNPACK_BUFFER_BINDING = 0x88EF;

		/// <summary>
		/// Value of GL_FLOAT_MAT2x3 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int FLOAT_MAT2x3 = 0x8B65;

		/// <summary>
		/// Value of GL_FLOAT_MAT2x4 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int FLOAT_MAT2x4 = 0x8B66;

		/// <summary>
		/// Value of GL_FLOAT_MAT3x2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int FLOAT_MAT3x2 = 0x8B67;

		/// <summary>
		/// Value of GL_FLOAT_MAT3x4 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int FLOAT_MAT3x4 = 0x8B68;

		/// <summary>
		/// Value of GL_FLOAT_MAT4x2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int FLOAT_MAT4x2 = 0x8B69;

		/// <summary>
		/// Value of GL_FLOAT_MAT4x3 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int FLOAT_MAT4x3 = 0x8B6A;

		/// <summary>
		/// Value of GL_SRGB symbol.
		/// </summary>
		[AliasOf("GL_SRGB_EXT")]
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int SRGB = 0x8C40;

		/// <summary>
		/// Value of GL_SRGB8 symbol.
		/// </summary>
		[AliasOf("GL_SRGB8_EXT")]
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int SRGB8 = 0x8C41;

		/// <summary>
		/// Value of GL_SRGB_ALPHA symbol.
		/// </summary>
		[AliasOf("GL_SRGB_ALPHA_EXT")]
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int SRGB_ALPHA = 0x8C42;

		/// <summary>
		/// Value of GL_SRGB8_ALPHA8 symbol.
		/// </summary>
		[AliasOf("GL_SRGB8_ALPHA8_EXT")]
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int SRGB8_ALPHA8 = 0x8C43;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_SRGB_EXT")]
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int COMPRESSED_SRGB = 0x8C48;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB_ALPHA symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_SRGB_ALPHA_EXT")]
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int COMPRESSED_SRGB_ALPHA = 0x8C49;

		/// <summary>
		/// Gl.Get: params returns four values: the red, green, blue, and alpha secondary color values of the current raster 
		/// position. Integer values, if requested, are linearly mapped from the internal floating-point representation such that 
		/// 1.0 returns the most positive representable integer value, and -1.0 returns the most negative representable integer 
		/// value. The initial value is (1, 1, 1, 1). See Gl.RasterPos.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_RASTER_SECONDARY_COLOR = 0x845F;

		/// <summary>
		/// Value of GL_SLUMINANCE_ALPHA symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_SLUMINANCE_ALPHA_EXT")]
		[RequiredByFeature("GL_VERSION_2_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SLUMINANCE_ALPHA = 0x8C44;

		/// <summary>
		/// Value of GL_SLUMINANCE8_ALPHA8 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_SLUMINANCE8_ALPHA8_EXT")]
		[RequiredByFeature("GL_VERSION_2_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SLUMINANCE8_ALPHA8 = 0x8C45;

		/// <summary>
		/// Value of GL_SLUMINANCE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_SLUMINANCE_EXT")]
		[RequiredByFeature("GL_VERSION_2_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SLUMINANCE = 0x8C46;

		/// <summary>
		/// Value of GL_SLUMINANCE8 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_SLUMINANCE8_EXT")]
		[RequiredByFeature("GL_VERSION_2_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SLUMINANCE8 = 0x8C47;

		/// <summary>
		/// Value of GL_COMPRESSED_SLUMINANCE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_COMPRESSED_SLUMINANCE_EXT")]
		[RequiredByFeature("GL_VERSION_2_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COMPRESSED_SLUMINANCE = 0x8C4A;

		/// <summary>
		/// Value of GL_COMPRESSED_SLUMINANCE_ALPHA symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_COMPRESSED_SLUMINANCE_ALPHA_EXT")]
		[RequiredByFeature("GL_VERSION_2_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COMPRESSED_SLUMINANCE_ALPHA = 0x8C4B;

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_1")]
		public static void UniformMatrix2x3(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix2x3fv != null, "pglUniformMatrix2x3fv not implemented");
					Delegates.pglUniformMatrix2x3fv(location, count, transpose, p_value);
					CallLog("glUniformMatrix2x3fv({0}, {1}, {2}, {3})", location, count, transpose, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_1")]
		public static void UniformMatrix3x2(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix3x2fv != null, "pglUniformMatrix3x2fv not implemented");
					Delegates.pglUniformMatrix3x2fv(location, count, transpose, p_value);
					CallLog("glUniformMatrix3x2fv({0}, {1}, {2}, {3})", location, count, transpose, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_1")]
		public static void UniformMatrix2x4(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix2x4fv != null, "pglUniformMatrix2x4fv not implemented");
					Delegates.pglUniformMatrix2x4fv(location, count, transpose, p_value);
					CallLog("glUniformMatrix2x4fv({0}, {1}, {2}, {3})", location, count, transpose, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_1")]
		public static void UniformMatrix4x2(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix4x2fv != null, "pglUniformMatrix4x2fv not implemented");
					Delegates.pglUniformMatrix4x2fv(location, count, transpose, p_value);
					CallLog("glUniformMatrix4x2fv({0}, {1}, {2}, {3})", location, count, transpose, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_1")]
		public static void UniformMatrix3x4(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix3x4fv != null, "pglUniformMatrix3x4fv not implemented");
					Delegates.pglUniformMatrix3x4fv(location, count, transpose, p_value);
					CallLog("glUniformMatrix3x4fv({0}, {1}, {2}, {3})", location, count, transpose, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_1")]
		public static void UniformMatrix4x3(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix4x3fv != null, "pglUniformMatrix4x3fv not implemented");
					Delegates.pglUniformMatrix4x3fv(location, count, transpose, p_value);
					CallLog("glUniformMatrix4x3fv({0}, {1}, {2}, {3})", location, count, transpose, value);
				}
			}
			DebugCheckErrors();
		}

	}

}
