/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class StreamingLongIntFeatures : StreamingDotFeatures {
  private HandleRef swigCPtr;

  internal StreamingLongIntFeatures(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.StreamingLongIntFeaturesUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(StreamingLongIntFeatures obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~StreamingLongIntFeatures() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_StreamingLongIntFeatures(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public StreamingLongIntFeatures() : this(modshogunPINVOKE.new_StreamingLongIntFeatures__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StreamingLongIntFeatures(StreamingFile file, bool is_labelled, int size) : this(modshogunPINVOKE.new_StreamingLongIntFeatures__SWIG_1(StreamingFile.getCPtr(file), is_labelled, size), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StreamingLongIntFeatures(LongIntFeatures simple_features, SWIGTYPE_p_double lab) : this(modshogunPINVOKE.new_StreamingLongIntFeatures__SWIG_2(LongIntFeatures.getCPtr(simple_features), SWIGTYPE_p_double.getCPtr(lab)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StreamingLongIntFeatures(LongIntFeatures simple_features) : this(modshogunPINVOKE.new_StreamingLongIntFeatures__SWIG_3(LongIntFeatures.getCPtr(simple_features)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public long[] get_vector() {
		IntPtr ptr = modshogunPINVOKE.StreamingLongIntFeatures_get_vector(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
		int[] size = new int[1];
		Marshal.Copy(ptr, size, 0, 1);

		int len = size[0];

		long[] ret = new long[len];

		Marshal.Copy(new IntPtr(ptr.ToInt64() + Marshal.SizeOf(typeof(int))), ret, 0, len);
		return ret;
}

  public virtual float dot(long[] vec) {
    float ret = modshogunPINVOKE.StreamingLongIntFeatures_dot__SWIG_0(swigCPtr, vec.Length, vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override float dot(StreamingDotFeatures df) {
    float ret = modshogunPINVOKE.StreamingLongIntFeatures_dot__SWIG_1(swigCPtr, StreamingDotFeatures.getCPtr(df));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
