//
// System.Reflection/Assembly.cs
//
// Author:
//   Paolo Molaro (lupus@ximian.com)
//
// (C) 2001 Ximian, Inc.  http://www.ximian.com
//

using System;
using System.Security.Policy;
using System.Runtime.Serialization;
using System.Reflection.Emit;
using System.IO;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System.Reflection {

	public class Assembly : System.Reflection.ICustomAttributeProvider,
		System.Security.IEvidenceFactory, System.Runtime.Serialization.ISerializable {
		private IntPtr _mono_assembly;

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern string get_code_base ();
		
		public virtual string CodeBase { get { return get_code_base (); } }

		public virtual string CopiedCodeBase { get {return null;} } 

		public virtual string FullName { get {return null;} }

		public virtual MethodInfo EntryPoint { get {return null;} }

		public virtual Evidence Evidence { get {return null;} }

		public virtual String Location { get {return null;} }

		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		public virtual Boolean IsDefined(Type attributeType)
		{
			return false;
		}

		public virtual bool IsDefined (Type attribute_type, bool inherit)
		{
			return false;
		}

		public virtual Object[] GetCustomAttributes()
		{
			return null;
		}

		public virtual Object[] GetCustomAttributes(Type attributeType)
		{
			return null;
		}
		
		public virtual object [] GetCustomAttributes (bool inherit)
		{
			return null;
		}

		public virtual object [] GetCustomAttributes (Type attribute_type, bool inherit)
		{
			return null;
		}

		public virtual void RemoveOnTypeResolve(ResolveEventHandler handler)
		{
			throw new NotImplementedException ();
		}

		public virtual void AddOnTypeResolve(ResolveEventHandler handler)
		{
			throw new NotImplementedException ();
		}

		public virtual void RemoveOnResourceResolve(ResolveEventHandler handler)
		{
			throw new NotImplementedException ();
		}
		
		public virtual void AddOnResourceResolve(ResolveEventHandler handler)
		{
			throw new NotImplementedException ();
		}

		public virtual ModuleBuilder DefineDynamicModule(String name, Boolean emitSymbolInfo)
		{
			throw new NotImplementedException ();
		}

		public virtual ModuleBuilder DefineDynamicModule(String name)
		{
			throw new NotImplementedException ();
		}

		public virtual FileStream[] GetFiles()
		{
			throw new NotImplementedException ();
		}

		public virtual FileStream GetFile(String name)
		{
			throw new NotImplementedException ();
		}

		public virtual Stream GetManifestResourceStream(String name)
		{
			throw new NotImplementedException ();
		}

		public virtual Stream GetManifestResourceStream(Type type, String name)
		{
			throw new NotImplementedException ();
		}

		public virtual Type[] GetTypes()
		{
			throw new NotImplementedException ();
		}

		public virtual Type[] GetExportedTypes()
		{
			throw new NotImplementedException ();
		}

		public virtual Type GetType(String name, Boolean throwOnError)
		{
			return GetType (name, throwOnError, false);
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern virtual Type GetType(String name);

		public Type GetType(String name, Boolean throwOnError, Boolean ignoreCase)
		{
			throw new NotImplementedException ();
		}
		
		public virtual AssemblyName GetName(Boolean copiedName)
		{
			throw new NotImplementedException ();
		}

		public virtual AssemblyName GetName()
		{
			throw new NotImplementedException ();
		}

		public override String ToString()
		{
			return GetName ().Name;
		}

		[MonoTODO]
		public static String CreateQualifiedName(String assemblyName, String typeName) 
		{
			return "FIXME: assembly";
		}

		[MonoTODO]
		public static String nCreateQualifiedName(String assemblyName, String typeName)
		{
			return "FIXME: assembly";
		}

		[MonoTODO]
		public static Assembly GetAssembly(Type type)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public Assembly GetSatelliteAssembly(CultureInfo culture)
		{
			throw new NotImplementedException ();
		}

		public static Assembly LoadFrom(String assemblyFile)
		{
			return LoadFrom (assemblyFile, new Evidence());
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public static extern Assembly LoadFrom(String assemblyFile, Evidence securityEvidence);

		public static Assembly Load(String assemblyString)
		{
			return LoadFrom (assemblyString, new Evidence());
		}
		
		public static Assembly Load(String assemblyString, Evidence assemblySecurity)
		{
			return LoadFrom (assemblyString, assemblySecurity);
		}

		public static Assembly Load(AssemblyName assemblyRef)
		{
			throw new NotImplementedException ();
		}

		public static Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity)
		{
			throw new NotImplementedException ();
		}

		public static Assembly Load(Byte[] rawAssembly)
		{
			throw new NotImplementedException ();
		}

		public static Assembly Load(Byte[] rawAssembly, Byte[] rawSymbolStore)
		{
			throw new NotImplementedException ();
		}

		public static Assembly Load(Byte[] rawAssembly, Byte[] rawSymbolStore, Evidence securityEvidence)
		{
			throw new NotImplementedException ();
		}

		public Object CreateInstance(String typeName) 
		{
			throw new NotImplementedException ();
		}

		public Object CreateInstance(String typeName, Boolean ignoreCase)
		{
			throw new NotImplementedException ();
		}

		public Object CreateInstance(String typeName, Boolean ignoreCase, BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture, Object[] activationAttributes)
		{
			throw new NotImplementedException ();
		}

		public Module[] GetLoadedModules()
		{
			throw new NotImplementedException ();
		}

		public Module[] GetModules()
		{
			throw new NotImplementedException ();
		}

		public Module GetModule(String name)
		{
			throw new NotImplementedException ();
		}

		public String[] GetManifestResourceNames()
		{
			throw new NotImplementedException ();
		}

		public static Assembly GetExecutingAssembly()
		{
			throw new NotImplementedException ();
		}

		public AssemblyName[] GetReferencedAssemblies()
		{
			throw new NotImplementedException ();
		}

		public ManifestResourceInfo GetManifestResourceInfo(String resourceName)
		{
			throw new NotImplementedException ();
		}

		public static Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity, String callerLocation)
		{
			throw new NotImplementedException ();
		}

		public static Assembly Load(String assemblyString, Evidence assemblySecurity, String callerLocation)
		{
			throw new NotImplementedException ();
		}

	}
}
