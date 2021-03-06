/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class GaussianKernel : DotKernel {
  private HandleRef swigCPtr;

  internal GaussianKernel(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.GaussianKernelUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(GaussianKernel obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~GaussianKernel() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_GaussianKernel(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public GaussianKernel() : this(modshogunPINVOKE.new_GaussianKernel__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public GaussianKernel(int size, double width) : this(modshogunPINVOKE.new_GaussianKernel__SWIG_1(size, width), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public GaussianKernel(DotFeatures l, DotFeatures r, double width, int size) : this(modshogunPINVOKE.new_GaussianKernel__SWIG_2(DotFeatures.getCPtr(l), DotFeatures.getCPtr(r), width, size), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public GaussianKernel(DotFeatures l, DotFeatures r, double width) : this(modshogunPINVOKE.new_GaussianKernel__SWIG_3(DotFeatures.getCPtr(l), DotFeatures.getCPtr(r), width), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_width(double w) {
    modshogunPINVOKE.GaussianKernel_set_width(swigCPtr, w);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double get_width() {
    double ret = modshogunPINVOKE.GaussianKernel_get_width(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_compact_enabled(bool compact) {
    modshogunPINVOKE.GaussianKernel_set_compact_enabled(swigCPtr, compact);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool get_compact_enabled() {
    bool ret = modshogunPINVOKE.GaussianKernel_get_compact_enabled(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
