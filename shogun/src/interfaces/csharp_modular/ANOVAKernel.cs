/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class ANOVAKernel : DotKernel {
  private HandleRef swigCPtr;

  internal ANOVAKernel(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.ANOVAKernelUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ANOVAKernel obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ANOVAKernel() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_ANOVAKernel(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public ANOVAKernel() : this(modshogunPINVOKE.new_ANOVAKernel__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public ANOVAKernel(int cache, int d) : this(modshogunPINVOKE.new_ANOVAKernel__SWIG_1(cache, d), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public ANOVAKernel(RealFeatures l, RealFeatures r, int d, int cache) : this(modshogunPINVOKE.new_ANOVAKernel__SWIG_2(RealFeatures.getCPtr(l), RealFeatures.getCPtr(r), d, cache), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public int get_cardinality() {
    int ret = modshogunPINVOKE.ANOVAKernel_get_cardinality(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_cardinality(int value) {
    modshogunPINVOKE.ANOVAKernel_set_cardinality(swigCPtr, value);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public double compute_rec1(int idx_a, int idx_b) {
    double ret = modshogunPINVOKE.ANOVAKernel_compute_rec1(swigCPtr, idx_a, idx_b);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double compute_rec2(int idx_a, int idx_b) {
    double ret = modshogunPINVOKE.ANOVAKernel_compute_rec2(swigCPtr, idx_a, idx_b);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
