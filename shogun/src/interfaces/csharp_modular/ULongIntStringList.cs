/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class ULongIntStringList : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ULongIntStringList(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ULongIntStringList obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ULongIntStringList() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_ULongIntStringList(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public ULongIntStringList() : this(modshogunPINVOKE.new_ULongIntStringList__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public ULongIntStringList(SWIGTYPE_p_shogun__SGStringT_unsigned_long_long_t s, int num_s, int max_length, bool free_strings) : this(modshogunPINVOKE.new_ULongIntStringList__SWIG_1(SWIGTYPE_p_shogun__SGStringT_unsigned_long_long_t.getCPtr(s), num_s, max_length, free_strings), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public ULongIntStringList(SWIGTYPE_p_shogun__SGStringT_unsigned_long_long_t s, int num_s, int max_length) : this(modshogunPINVOKE.new_ULongIntStringList__SWIG_2(SWIGTYPE_p_shogun__SGStringT_unsigned_long_long_t.getCPtr(s), num_s, max_length), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public ULongIntStringList(int num_s, int max_length, bool free_strings) : this(modshogunPINVOKE.new_ULongIntStringList__SWIG_3(num_s, max_length, free_strings), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public ULongIntStringList(int num_s, int max_length) : this(modshogunPINVOKE.new_ULongIntStringList__SWIG_4(num_s, max_length), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public ULongIntStringList(ULongIntStringList orig) : this(modshogunPINVOKE.new_ULongIntStringList__SWIG_5(ULongIntStringList.getCPtr(orig)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void free_list() {
    modshogunPINVOKE.ULongIntStringList_free_list(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void destroy_list() {
    modshogunPINVOKE.ULongIntStringList_destroy_list(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public int num_strings {
    set {
      modshogunPINVOKE.ULongIntStringList_num_strings_set(swigCPtr, value);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = modshogunPINVOKE.ULongIntStringList_num_strings_get(swigCPtr);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int max_string_length {
    set {
      modshogunPINVOKE.ULongIntStringList_max_string_length_set(swigCPtr, value);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = modshogunPINVOKE.ULongIntStringList_max_string_length_get(swigCPtr);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_shogun__SGStringT_unsigned_long_long_t strings {
    set {
      modshogunPINVOKE.ULongIntStringList_strings_set(swigCPtr, SWIGTYPE_p_shogun__SGStringT_unsigned_long_long_t.getCPtr(value));
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = modshogunPINVOKE.ULongIntStringList_strings_get(swigCPtr);
      SWIGTYPE_p_shogun__SGStringT_unsigned_long_long_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_shogun__SGStringT_unsigned_long_long_t(cPtr, false);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool do_free {
    set {
      modshogunPINVOKE.ULongIntStringList_do_free_set(swigCPtr, value);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = modshogunPINVOKE.ULongIntStringList_do_free_get(swigCPtr);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool save_serializable(SerializableFile file, string prefix) {
    bool ret = modshogunPINVOKE.ULongIntStringList_save_serializable__SWIG_0(swigCPtr, SerializableFile.getCPtr(file), prefix);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool save_serializable(SerializableFile file) {
    bool ret = modshogunPINVOKE.ULongIntStringList_save_serializable__SWIG_1(swigCPtr, SerializableFile.getCPtr(file));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool load_serializable(SerializableFile file, string prefix) {
    bool ret = modshogunPINVOKE.ULongIntStringList_load_serializable__SWIG_0(swigCPtr, SerializableFile.getCPtr(file), prefix);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool load_serializable(SerializableFile file) {
    bool ret = modshogunPINVOKE.ULongIntStringList_load_serializable__SWIG_1(swigCPtr, SerializableFile.getCPtr(file));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}