/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CrossValidation : SGObject {
  private HandleRef swigCPtr;

  internal CrossValidation(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.CrossValidationUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CrossValidation obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CrossValidation() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_CrossValidation(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public CrossValidation() : this(modshogunPINVOKE.new_CrossValidation__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public CrossValidation(Machine machine, Features features, Labels labels, SplittingStrategy splitting_strategy, Evaluation evaluation_criterium) : this(modshogunPINVOKE.new_CrossValidation__SWIG_1(Machine.getCPtr(machine), Features.getCPtr(features), Labels.getCPtr(labels), SplittingStrategy.getCPtr(splitting_strategy), Evaluation.getCPtr(evaluation_criterium)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public EEvaluationDirection get_evaluation_direction() {
    EEvaluationDirection ret = (EEvaluationDirection)modshogunPINVOKE.CrossValidation_get_evaluation_direction(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CrossValidationResult evaluate() {
    CrossValidationResult ret = new CrossValidationResult(modshogunPINVOKE.CrossValidation_evaluate(swigCPtr), true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Machine get_machine() {
    IntPtr cPtr = modshogunPINVOKE.CrossValidation_get_machine(swigCPtr);
    Machine ret = (cPtr == IntPtr.Zero) ? null : new Machine(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_num_runs(int num_runs) {
    modshogunPINVOKE.CrossValidation_set_num_runs(swigCPtr, num_runs);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_conf_int_alpha(double m_conf_int_alpha) {
    modshogunPINVOKE.CrossValidation_set_conf_int_alpha(swigCPtr, m_conf_int_alpha);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}
