/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class DynamicCharArray : SGObject {
  private HandleRef swigCPtr;

  internal DynamicCharArray(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.DynamicCharArrayUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(DynamicCharArray obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~DynamicCharArray() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_DynamicCharArray(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public DynamicCharArray(int p_resize_granularity) : this(modshogunPINVOKE.new_DynamicCharArray__SWIG_0(p_resize_granularity), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public DynamicCharArray() : this(modshogunPINVOKE.new_DynamicCharArray__SWIG_1(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public int set_granularity(int g) {
    int ret = modshogunPINVOKE.DynamicCharArray_set_granularity(swigCPtr, g);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int get_array_size() {
    int ret = modshogunPINVOKE.DynamicCharArray_get_array_size(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int get_num_elements() {
    int ret = modshogunPINVOKE.DynamicCharArray_get_num_elements(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public char get_element(int index) {
    char ret = modshogunPINVOKE.DynamicCharArray_get_element(swigCPtr, index);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public char get_element_safe(int index) {
    char ret = modshogunPINVOKE.DynamicCharArray_get_element_safe(swigCPtr, index);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool set_element(char element, int index) {
    bool ret = modshogunPINVOKE.DynamicCharArray_set_element(swigCPtr, element, index);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool insert_element(char element, int index) {
    bool ret = modshogunPINVOKE.DynamicCharArray_insert_element(swigCPtr, element, index);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool append_element(char element) {
    bool ret = modshogunPINVOKE.DynamicCharArray_append_element(swigCPtr, element);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void push_back(char element) {
    modshogunPINVOKE.DynamicCharArray_push_back(swigCPtr, element);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void pop_back() {
    modshogunPINVOKE.DynamicCharArray_pop_back(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public char back() {
    char ret = modshogunPINVOKE.DynamicCharArray_back(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int find_element(char element) {
    int ret = modshogunPINVOKE.DynamicCharArray_find_element(swigCPtr, element);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool delete_element(int idx) {
    bool ret = modshogunPINVOKE.DynamicCharArray_delete_element(swigCPtr, idx);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool resize_array(int n) {
    bool ret = modshogunPINVOKE.DynamicCharArray_resize_array(swigCPtr, n);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string get_array() {
    string ret = modshogunPINVOKE.DynamicCharArray_get_array(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_array(string p_array, int p_num_elements, int array_size) {
    modshogunPINVOKE.DynamicCharArray_set_array(swigCPtr, p_array, p_num_elements, array_size);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void clear_array() {
    modshogunPINVOKE.DynamicCharArray_clear_array(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void shuffle() {
    modshogunPINVOKE.DynamicCharArray_shuffle(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool save_serializable(SerializableFile file, string prefix) {
    bool ret = modshogunPINVOKE.DynamicCharArray_save_serializable__SWIG_0(swigCPtr, SerializableFile.getCPtr(file), prefix);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool save_serializable(SerializableFile file) {
    bool ret = modshogunPINVOKE.DynamicCharArray_save_serializable__SWIG_1(swigCPtr, SerializableFile.getCPtr(file));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool load_serializable(SerializableFile file, string prefix) {
    bool ret = modshogunPINVOKE.DynamicCharArray_load_serializable__SWIG_0(swigCPtr, SerializableFile.getCPtr(file), prefix);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool load_serializable(SerializableFile file) {
    bool ret = modshogunPINVOKE.DynamicCharArray_load_serializable__SWIG_1(swigCPtr, SerializableFile.getCPtr(file));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
