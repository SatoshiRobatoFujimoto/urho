// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// SpriteSheet2D.cs
// 
// Copyright 2015 Xamarin Inc. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Urho.Urho2D;
using Urho.Gui;
using Urho.Resources;
using Urho.IO;
using Urho.Navigation;
using Urho.Network;

namespace Urho.Urho2D
{
	/// <summary>
	/// Sprite sheet.
	/// </summary>
	public unsafe partial class SpriteSheet2D : Resource
	{
		public SpriteSheet2D (IntPtr handle) : base (handle)
		{
		}

		protected SpriteSheet2D (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int SpriteSheet2D_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (SpriteSheet2D_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr SpriteSheet2D_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (SpriteSheet2D_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int SpriteSheet2D_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(SpriteSheet2D));
			return new StringHash (SpriteSheet2D_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr SpriteSheet2D_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(SpriteSheet2D));
			return Marshal.PtrToStringAnsi (SpriteSheet2D_GetTypeNameStatic ());
		}

		public SpriteSheet2D () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr SpriteSheet2D_SpriteSheet2D (IntPtr context);

		public SpriteSheet2D (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(SpriteSheet2D));
			handle = SpriteSheet2D_SpriteSheet2D ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void SpriteSheet2D_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(SpriteSheet2D));
			SpriteSheet2D_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool SpriteSheet2D_BeginLoad_File (IntPtr handle, IntPtr source);

		/// <summary>
		/// Load resource from stream. May be called from a worker thread. Return true if successful.
		/// </summary>
		public override bool BeginLoad (File source)
		{
			Runtime.ValidateRefCounted (this);
			return SpriteSheet2D_BeginLoad_File (handle, (object)source == null ? IntPtr.Zero : source.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool SpriteSheet2D_BeginLoad_MemoryBuffer (IntPtr handle, IntPtr source);

		/// <summary>
		/// Load resource from stream. May be called from a worker thread. Return true if successful.
		/// </summary>
		public override bool BeginLoad (MemoryBuffer source)
		{
			Runtime.ValidateRefCounted (this);
			return SpriteSheet2D_BeginLoad_MemoryBuffer (handle, (object)source == null ? IntPtr.Zero : source.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool SpriteSheet2D_EndLoad (IntPtr handle);

		/// <summary>
		/// Finish resource loading. Always called from the main thread. Return true if successful.
		/// </summary>
		public override bool EndLoad ()
		{
			Runtime.ValidateRefCounted (this);
			return SpriteSheet2D_EndLoad (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void SpriteSheet2D_SetTexture (IntPtr handle, IntPtr texture);

		/// <summary>
		/// Set texture.
		/// </summary>
		private void SetTexture (Texture2D texture)
		{
			Runtime.ValidateRefCounted (this);
			SpriteSheet2D_SetTexture (handle, (object)texture == null ? IntPtr.Zero : texture.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void SpriteSheet2D_DefineSprite (IntPtr handle, string name, ref Urho.IntRect rectangle, ref Urho.Vector2 hotSpot, ref Urho.IntVector2 offset);

		/// <summary>
		/// Define sprite.
		/// </summary>
		public void DefineSprite (string name, Urho.IntRect rectangle, Urho.Vector2 hotSpot, Urho.IntVector2 offset)
		{
			Runtime.ValidateRefCounted (this);
			SpriteSheet2D_DefineSprite (handle, name, ref rectangle, ref hotSpot, ref offset);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr SpriteSheet2D_GetTexture (IntPtr handle);

		/// <summary>
		/// Return texture.
		/// </summary>
		private Texture2D GetTexture ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Texture2D> (SpriteSheet2D_GetTexture (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr SpriteSheet2D_GetSprite (IntPtr handle, string name);

		/// <summary>
		/// Return sprite.
		/// </summary>
		public Sprite2D GetSprite (string name)
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Sprite2D> (SpriteSheet2D_GetSprite (handle, name));
		}

		public override StringHash Type {
			get {
				return UrhoGetType ();
			}
		}

		public override string TypeName {
			get {
				return GetTypeName ();
			}
		}

		public new static StringHash TypeStatic {
			get {
				return GetTypeStatic ();
			}
		}

		public new static string TypeNameStatic {
			get {
				return GetTypeNameStatic ();
			}
		}

		/// <summary>
		/// Return texture.
		/// Or
		/// Set texture.
		/// </summary>
		public Texture2D Texture {
			get {
				return GetTexture ();
			}
			set {
				SetTexture (value);
			}
		}
	}
}
