/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class List : SGObject {
  private HandleRef swigCPtr;

  internal List(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.ListUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(List obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~List() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_List(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public List(bool p_delete_data) : this(modshogunPINVOKE.new_List__SWIG_0(p_delete_data), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public List() : this(modshogunPINVOKE.new_List__SWIG_1(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public int get_num_elements() {
    int ret = modshogunPINVOKE.List_get_num_elements(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SGObject get_first_element() {
    IntPtr cPtr = modshogunPINVOKE.List_get_first_element__SWIG_0(swigCPtr);
    SGObject ret = (cPtr == IntPtr.Zero) ? null : new SGObject(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SGObject get_last_element() {
    IntPtr cPtr = modshogunPINVOKE.List_get_last_element__SWIG_0(swigCPtr);
    SGObject ret = (cPtr == IntPtr.Zero) ? null : new SGObject(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SGObject get_next_element() {
    IntPtr cPtr = modshogunPINVOKE.List_get_next_element__SWIG_0(swigCPtr);
    SGObject ret = (cPtr == IntPtr.Zero) ? null : new SGObject(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SGObject get_previous_element() {
    IntPtr cPtr = modshogunPINVOKE.List_get_previous_element__SWIG_0(swigCPtr);
    SGObject ret = (cPtr == IntPtr.Zero) ? null : new SGObject(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SGObject get_current_element() {
    IntPtr cPtr = modshogunPINVOKE.List_get_current_element__SWIG_0(swigCPtr);
    SGObject ret = (cPtr == IntPtr.Zero) ? null : new SGObject(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SGObject get_first_element(ListElement p_current) {
    IntPtr cPtr = modshogunPINVOKE.List_get_first_element__SWIG_1(swigCPtr, ListElement.getCPtr(p_current));
    SGObject ret = (cPtr == IntPtr.Zero) ? null : new SGObject(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SGObject get_last_element(ListElement p_current) {
    IntPtr cPtr = modshogunPINVOKE.List_get_last_element__SWIG_1(swigCPtr, ListElement.getCPtr(p_current));
    SGObject ret = (cPtr == IntPtr.Zero) ? null : new SGObject(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SGObject get_next_element(ListElement p_current) {
    IntPtr cPtr = modshogunPINVOKE.List_get_next_element__SWIG_1(swigCPtr, ListElement.getCPtr(p_current));
    SGObject ret = (cPtr == IntPtr.Zero) ? null : new SGObject(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SGObject get_previous_element(ListElement p_current) {
    IntPtr cPtr = modshogunPINVOKE.List_get_previous_element__SWIG_1(swigCPtr, ListElement.getCPtr(p_current));
    SGObject ret = (cPtr == IntPtr.Zero) ? null : new SGObject(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SGObject get_current_element(ListElement p_current) {
    IntPtr cPtr = modshogunPINVOKE.List_get_current_element__SWIG_1(swigCPtr, ListElement.getCPtr(p_current));
    SGObject ret = (cPtr == IntPtr.Zero) ? null : new SGObject(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool append_element(SGObject data) {
    bool ret = modshogunPINVOKE.List_append_element(swigCPtr, SGObject.getCPtr(data));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool append_element_at_listend(SGObject data) {
    bool ret = modshogunPINVOKE.List_append_element_at_listend(swigCPtr, SGObject.getCPtr(data));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool insert_element(SGObject data) {
    bool ret = modshogunPINVOKE.List_insert_element(swigCPtr, SGObject.getCPtr(data));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SGObject delete_element() {
    IntPtr cPtr = modshogunPINVOKE.List_delete_element(swigCPtr);
    SGObject ret = (cPtr == IntPtr.Zero) ? null : new SGObject(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void load_serializable_post() {
    modshogunPINVOKE.List_load_serializable_post(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}