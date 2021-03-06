/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class HashedWDFeatures : DotFeatures {
  private HandleRef swigCPtr;

  internal HashedWDFeatures(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.HashedWDFeaturesUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(HashedWDFeatures obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~HashedWDFeatures() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_HashedWDFeatures(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public HashedWDFeatures() : this(modshogunPINVOKE.new_HashedWDFeatures__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public HashedWDFeatures(StringByteFeatures str, int start_order, int order, int from_order, int hash_bits) : this(modshogunPINVOKE.new_HashedWDFeatures__SWIG_1(StringByteFeatures.getCPtr(str), start_order, order, from_order, hash_bits), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public HashedWDFeatures(StringByteFeatures str, int start_order, int order, int from_order) : this(modshogunPINVOKE.new_HashedWDFeatures__SWIG_2(StringByteFeatures.getCPtr(str), start_order, order, from_order), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public HashedWDFeatures(HashedWDFeatures orig) : this(modshogunPINVOKE.new_HashedWDFeatures__SWIG_3(HashedWDFeatures.getCPtr(orig)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_normalization_const(double n) {
    modshogunPINVOKE.HashedWDFeatures_set_normalization_const__SWIG_0(swigCPtr, n);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_normalization_const() {
    modshogunPINVOKE.HashedWDFeatures_set_normalization_const__SWIG_1(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public double get_normalization_const() {
    double ret = modshogunPINVOKE.HashedWDFeatures_get_normalization_const(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
