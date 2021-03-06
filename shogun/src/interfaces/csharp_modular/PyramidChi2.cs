/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class PyramidChi2 : DotKernel {
  private HandleRef swigCPtr;

  internal PyramidChi2(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.PyramidChi2Upcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(PyramidChi2 obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~PyramidChi2() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_PyramidChi2(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PyramidChi2() : this(modshogunPINVOKE.new_PyramidChi2__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public PyramidChi2(int size, int num_cells2, SWIGTYPE_p_double weights_foreach_cell2, int width_computation_type2, double width2) : this(modshogunPINVOKE.new_PyramidChi2__SWIG_1(size, num_cells2, SWIGTYPE_p_double.getCPtr(weights_foreach_cell2), width_computation_type2, width2), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public PyramidChi2(RealFeatures l, RealFeatures r, int size, int num_cells2, SWIGTYPE_p_double weights_foreach_cell2, int width_computation_type2, double width2) : this(modshogunPINVOKE.new_PyramidChi2__SWIG_2(RealFeatures.getCPtr(l), RealFeatures.getCPtr(r), size, num_cells2, SWIGTYPE_p_double.getCPtr(weights_foreach_cell2), width_computation_type2, width2), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setparams_pychi2(int num_cells2, SWIGTYPE_p_double weights_foreach_cell2, int width_computation_type2, double width2) {
    modshogunPINVOKE.PyramidChi2_setparams_pychi2(swigCPtr, num_cells2, SWIGTYPE_p_double.getCPtr(weights_foreach_cell2), width_computation_type2, width2);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}
