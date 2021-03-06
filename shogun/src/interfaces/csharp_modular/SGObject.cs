/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class SGObject : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SGObject(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(SGObject obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~SGObject() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_SGObject(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public int ref_count() {
    int ret = modshogunPINVOKE.SGObject_ref_count(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual string get_name() {
    string ret = modshogunPINVOKE.SGObject_get_name(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool is_generic(SWIGTYPE_p_EPrimitiveType generic) {
    bool ret = modshogunPINVOKE.SGObject_is_generic(swigCPtr, SWIGTYPE_p_EPrimitiveType.getCPtr(generic));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void unset_generic() {
    modshogunPINVOKE.SGObject_unset_generic(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void print_serializable(string prefix) {
    modshogunPINVOKE.SGObject_print_serializable__SWIG_0(swigCPtr, prefix);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void print_serializable() {
    modshogunPINVOKE.SGObject_print_serializable__SWIG_1(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool save_serializable(SerializableFile file, string prefix) {
    bool ret = modshogunPINVOKE.SGObject_save_serializable__SWIG_0(swigCPtr, SerializableFile.getCPtr(file), prefix);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool save_serializable(SerializableFile file) {
    bool ret = modshogunPINVOKE.SGObject_save_serializable__SWIG_1(swigCPtr, SerializableFile.getCPtr(file));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool load_serializable(SerializableFile file, string prefix) {
    bool ret = modshogunPINVOKE.SGObject_load_serializable__SWIG_0(swigCPtr, SerializableFile.getCPtr(file), prefix);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool load_serializable(SerializableFile file) {
    bool ret = modshogunPINVOKE.SGObject_load_serializable__SWIG_1(swigCPtr, SerializableFile.getCPtr(file));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_global_io(SGIO io) {
    modshogunPINVOKE.SGObject_set_global_io(swigCPtr, SGIO.getCPtr(io));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public SGIO get_global_io() {
    IntPtr cPtr = modshogunPINVOKE.SGObject_get_global_io(swigCPtr);
    SGIO ret = (cPtr == IntPtr.Zero) ? null : new SGIO(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_global_parallel(Parallel parallel) {
    modshogunPINVOKE.SGObject_set_global_parallel(swigCPtr, Parallel.getCPtr(parallel));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public Parallel get_global_parallel() {
    IntPtr cPtr = modshogunPINVOKE.SGObject_get_global_parallel(swigCPtr);
    Parallel ret = (cPtr == IntPtr.Zero) ? null : new Parallel(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_global_version(Version version) {
    modshogunPINVOKE.SGObject_set_global_version(swigCPtr, Version.getCPtr(version));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public Version get_global_version() {
    IntPtr cPtr = modshogunPINVOKE.SGObject_get_global_version(swigCPtr);
    Version ret = (cPtr == IntPtr.Zero) ? null : new Version(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_SGVectorT_char_p_t get_modelsel_names() {
    SWIGTYPE_p_SGVectorT_char_p_t ret = new SWIGTYPE_p_SGVectorT_char_p_t(modshogunPINVOKE.SGObject_get_modelsel_names(swigCPtr), true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string get_modsel_param_descr(string param_name) {
    string ret = modshogunPINVOKE.SGObject_get_modsel_param_descr(swigCPtr, param_name);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_index_t get_modsel_param_index(string param_name) {
    SWIGTYPE_p_index_t ret = new SWIGTYPE_p_index_t(modshogunPINVOKE.SGObject_get_modsel_param_index(swigCPtr, param_name), true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SGIO io {
    set {
      modshogunPINVOKE.SGObject_io_set(swigCPtr, SGIO.getCPtr(value));
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = modshogunPINVOKE.SGObject_io_get(swigCPtr);
      SGIO ret = (cPtr == IntPtr.Zero) ? null : new SGIO(cPtr, false);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Parallel parallel {
    set {
      modshogunPINVOKE.SGObject_parallel_set(swigCPtr, Parallel.getCPtr(value));
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = modshogunPINVOKE.SGObject_parallel_get(swigCPtr);
      Parallel ret = (cPtr == IntPtr.Zero) ? null : new Parallel(cPtr, false);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Version version {
    set {
      modshogunPINVOKE.SGObject_version_set(swigCPtr, Version.getCPtr(value));
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = modshogunPINVOKE.SGObject_version_get(swigCPtr);
      Version ret = (cPtr == IntPtr.Zero) ? null : new Version(cPtr, false);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_shogun__Parameter m_parameters {
    set {
      modshogunPINVOKE.SGObject_m_parameters_set(swigCPtr, SWIGTYPE_p_shogun__Parameter.getCPtr(value));
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = modshogunPINVOKE.SGObject_m_parameters_get(swigCPtr);
      SWIGTYPE_p_shogun__Parameter ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_shogun__Parameter(cPtr, false);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_shogun__Parameter m_model_selection_parameters {
    set {
      modshogunPINVOKE.SGObject_m_model_selection_parameters_set(swigCPtr, SWIGTYPE_p_shogun__Parameter.getCPtr(value));
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = modshogunPINVOKE.SGObject_m_model_selection_parameters_get(swigCPtr);
      SWIGTYPE_p_shogun__Parameter ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_shogun__Parameter(cPtr, false);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}
