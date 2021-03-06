/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class DistanceKernel : Kernel {
  private HandleRef swigCPtr;

  internal DistanceKernel(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.DistanceKernelUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(DistanceKernel obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~DistanceKernel() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_DistanceKernel(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public DistanceKernel() : this(modshogunPINVOKE.new_DistanceKernel__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public DistanceKernel(int cache, double width, Distance dist) : this(modshogunPINVOKE.new_DistanceKernel__SWIG_1(cache, width, Distance.getCPtr(dist)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public DistanceKernel(Features l, Features r, double width, Distance dist) : this(modshogunPINVOKE.new_DistanceKernel__SWIG_2(Features.getCPtr(l), Features.getCPtr(r), width, Distance.getCPtr(dist)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void register_params() {
    modshogunPINVOKE.DistanceKernel_register_params(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_width(double w) {
    modshogunPINVOKE.DistanceKernel_set_width(swigCPtr, w);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double get_width() {
    double ret = modshogunPINVOKE.DistanceKernel_get_width(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
