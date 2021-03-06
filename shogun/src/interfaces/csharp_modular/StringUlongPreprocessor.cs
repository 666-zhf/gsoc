/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class StringUlongPreprocessor : Preprocessor {
  private HandleRef swigCPtr;

  internal StringUlongPreprocessor(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.StringUlongPreprocessorUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(StringUlongPreprocessor obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~StringUlongPreprocessor() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_StringUlongPreprocessor(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public virtual bool apply_to_string_features(Features f) {
    bool ret = modshogunPINVOKE.StringUlongPreprocessor_apply_to_string_features(swigCPtr, Features.getCPtr(f));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_unsigned_long_long apply_to_string(SWIGTYPE_p_unsigned_long_long f, SWIGTYPE_p_int len) {
    IntPtr cPtr = modshogunPINVOKE.StringUlongPreprocessor_apply_to_string(swigCPtr, SWIGTYPE_p_unsigned_long_long.getCPtr(f), SWIGTYPE_p_int.getCPtr(len));
    SWIGTYPE_p_unsigned_long_long ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_long_long(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
