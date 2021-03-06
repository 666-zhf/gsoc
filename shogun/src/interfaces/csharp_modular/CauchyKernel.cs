/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CauchyKernel : Kernel {
  private HandleRef swigCPtr;

  internal CauchyKernel(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.CauchyKernelUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CauchyKernel obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CauchyKernel() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_CauchyKernel(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public CauchyKernel() : this(modshogunPINVOKE.new_CauchyKernel__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public CauchyKernel(int cache, double sigma, Distance dist) : this(modshogunPINVOKE.new_CauchyKernel__SWIG_1(cache, sigma, Distance.getCPtr(dist)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public CauchyKernel(Features l, Features r, double sigma, Distance dist) : this(modshogunPINVOKE.new_CauchyKernel__SWIG_2(Features.getCPtr(l), Features.getCPtr(r), sigma, Distance.getCPtr(dist)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}
