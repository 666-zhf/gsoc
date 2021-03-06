/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class DynProg : SGObject {
  private HandleRef swigCPtr;

  internal DynProg(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.DynProgUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(DynProg obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~DynProg() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_DynProg(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public DynProg(int p_num_svms) : this(modshogunPINVOKE.new_DynProg__SWIG_0(p_num_svms), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public DynProg() : this(modshogunPINVOKE.new_DynProg__SWIG_1(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_num_states(int N) {
    modshogunPINVOKE.DynProg_set_num_states(swigCPtr, N);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public int get_num_states() {
    int ret = modshogunPINVOKE.DynProg_get_num_states(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int get_num_svms() {
    int ret = modshogunPINVOKE.DynProg_get_num_svms(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void init_content_svm_value_array(int p_num_svms) {
    modshogunPINVOKE.DynProg_init_content_svm_value_array(swigCPtr, p_num_svms);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void init_tiling_data(SWIGTYPE_p_int probe_pos, SWIGTYPE_p_double intensities, int num_probes) {
    modshogunPINVOKE.DynProg_init_tiling_data(swigCPtr, SWIGTYPE_p_int.getCPtr(probe_pos), SWIGTYPE_p_double.getCPtr(intensities), num_probes);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void precompute_tiling_plifs(SWIGTYPE_p_p_shogun__CPlif PEN, SWIGTYPE_p_int tiling_plif_ids, int num_tiling_plifs) {
    modshogunPINVOKE.DynProg_precompute_tiling_plifs(swigCPtr, SWIGTYPE_p_p_shogun__CPlif.getCPtr(PEN), SWIGTYPE_p_int.getCPtr(tiling_plif_ids), num_tiling_plifs);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void resize_lin_feat(int num_new_feat) {
    modshogunPINVOKE.DynProg_resize_lin_feat(swigCPtr, num_new_feat);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_p_vector(double[] p) {
    modshogunPINVOKE.DynProg_set_p_vector(swigCPtr, p.Length, p);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_q_vector(double[] q) {
    modshogunPINVOKE.DynProg_set_q_vector(swigCPtr, q.Length, q);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_a(double[,] a) {
    modshogunPINVOKE.DynProg_set_a__SWIG_0(swigCPtr, a.GetLength(0), a.GetLength(1), a);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_a_id(int[,] a) {
    modshogunPINVOKE.DynProg_set_a_id(swigCPtr, a.GetLength(0), a.GetLength(1), a);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_a_trans_matrix(double[,] a_trans) {
    modshogunPINVOKE.DynProg_set_a_trans_matrix(swigCPtr, a_trans.GetLength(0), a_trans.GetLength(1), a_trans);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void init_mod_words_array(int[,] p_mod_words_array) {
    modshogunPINVOKE.DynProg_init_mod_words_array(swigCPtr, p_mod_words_array.GetLength(0), p_mod_words_array.GetLength(1), p_mod_words_array);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool check_svm_arrays() {
    bool ret = modshogunPINVOKE.DynProg_check_svm_arrays(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_observation_matrix(RealNDArray seq) {
    modshogunPINVOKE.DynProg_set_observation_matrix(swigCPtr, RealNDArray.getCPtr(seq));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public int get_num_positions() {
    int ret = modshogunPINVOKE.DynProg_get_num_positions(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_content_type_array(double[,] seg_path) {
    modshogunPINVOKE.DynProg_set_content_type_array(swigCPtr, seg_path.GetLength(0), seg_path.GetLength(1), seg_path);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_pos(int[] pos) {
    modshogunPINVOKE.DynProg_set_pos(swigCPtr, pos.Length, pos);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_orf_info(int[,] orf_info) {
    modshogunPINVOKE.DynProg_set_orf_info(swigCPtr, orf_info.GetLength(0), orf_info.GetLength(1), orf_info);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_gene_string(byte[] genestr) {
    modshogunPINVOKE.DynProg_set_gene_string(swigCPtr, genestr.Length, genestr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_dict_weights(double[,] dictionary_weights) {
    modshogunPINVOKE.DynProg_set_dict_weights(swigCPtr, dictionary_weights.GetLength(0), dictionary_weights.GetLength(1), dictionary_weights);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void best_path_set_segment_loss(double[,] segment_loss) {
    modshogunPINVOKE.DynProg_best_path_set_segment_loss(swigCPtr, segment_loss.GetLength(0), segment_loss.GetLength(1), segment_loss);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void best_path_set_segment_ids_mask(SWIGTYPE_p_int segment_ids, SWIGTYPE_p_double segment_mask, int m) {
    modshogunPINVOKE.DynProg_best_path_set_segment_ids_mask(swigCPtr, SWIGTYPE_p_int.getCPtr(segment_ids), SWIGTYPE_p_double.getCPtr(segment_mask), m);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_sparse_features(SparseRealFeatures seq_sparse1, SparseRealFeatures seq_sparse2) {
    modshogunPINVOKE.DynProg_set_sparse_features(swigCPtr, SparseRealFeatures.getCPtr(seq_sparse1), SparseRealFeatures.getCPtr(seq_sparse2));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_plif_matrices(PlifMatrix pm) {
    modshogunPINVOKE.DynProg_set_plif_matrices(swigCPtr, PlifMatrix.getCPtr(pm));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public double[] get_scores() {
		IntPtr ptr = modshogunPINVOKE.DynProg_get_scores(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
		int[] size = new int[1];
		Marshal.Copy(ptr, size, 0, 1);

		int len = size[0];

		double[] ret = new double[len];

		Marshal.Copy(new IntPtr(ptr.ToInt64() + Marshal.SizeOf(typeof(int))), ret, 0, len);
		return ret;
}

  public int[,] get_states() {
	IntPtr ptr = modshogunPINVOKE.DynProg_get_states(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
	int[] ranks = new int[2];
	Marshal.Copy(ptr, ranks, 0, 2);

	int rows = ranks[0];
	int cols = ranks[1];
	int len = rows * cols;

	int[] ret = new int[len];

	Marshal.Copy(new IntPtr(ptr.ToInt64() + 2 * Marshal.SizeOf(typeof(int))), ret, 0, len);

	int[,] result = new int[rows, cols];
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < cols; j++) {
			result[i, j] = ret[i * cols + j];
		}
	}
	return result;
}

  public int[,] get_positions() {
	IntPtr ptr = modshogunPINVOKE.DynProg_get_positions(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
	int[] ranks = new int[2];
	Marshal.Copy(ptr, ranks, 0, 2);

	int rows = ranks[0];
	int cols = ranks[1];
	int len = rows * cols;

	int[] ret = new int[len];

	Marshal.Copy(new IntPtr(ptr.ToInt64() + 2 * Marshal.SizeOf(typeof(int))), ret, 0, len);

	int[,] result = new int[rows, cols];
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < cols; j++) {
			result[i, j] = ret[i * cols + j];
		}
	}
	return result;
}

  public void compute_nbest_paths(int max_num_signals, bool use_orf, short nbest, bool with_loss, bool with_multiple_sequences) {
    modshogunPINVOKE.DynProg_compute_nbest_paths(swigCPtr, max_num_signals, use_orf, nbest, with_loss, with_multiple_sequences);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void best_path_trans_deriv(SWIGTYPE_p_int my_state_seq, SWIGTYPE_p_int my_pos_seq, int my_seq_len, SWIGTYPE_p_double seq_array, int max_num_signals) {
    modshogunPINVOKE.DynProg_best_path_trans_deriv(swigCPtr, SWIGTYPE_p_int.getCPtr(my_state_seq), SWIGTYPE_p_int.getCPtr(my_pos_seq), my_seq_len, SWIGTYPE_p_double.getCPtr(seq_array), max_num_signals);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_my_state_seq(SWIGTYPE_p_int my_state_seq) {
    modshogunPINVOKE.DynProg_set_my_state_seq(swigCPtr, SWIGTYPE_p_int.getCPtr(my_state_seq));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_my_pos_seq(SWIGTYPE_p_int my_pos_seq) {
    modshogunPINVOKE.DynProg_set_my_pos_seq(swigCPtr, SWIGTYPE_p_int.getCPtr(my_pos_seq));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void get_path_scores(SWIGTYPE_p_p_double my_scores, SWIGTYPE_p_int seq_len) {
    modshogunPINVOKE.DynProg_get_path_scores(swigCPtr, SWIGTYPE_p_p_double.getCPtr(my_scores), SWIGTYPE_p_int.getCPtr(seq_len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void get_path_losses(SWIGTYPE_p_p_double my_losses, SWIGTYPE_p_int seq_len) {
    modshogunPINVOKE.DynProg_get_path_losses(swigCPtr, SWIGTYPE_p_p_double.getCPtr(my_losses), SWIGTYPE_p_int.getCPtr(seq_len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public ushort get_N() {
    ushort ret = modshogunPINVOKE.DynProg_get_N(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_q(ushort offset, double value) {
    modshogunPINVOKE.DynProg_set_q(swigCPtr, offset, value);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_p(ushort offset, double value) {
    modshogunPINVOKE.DynProg_set_p(swigCPtr, offset, value);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_a(ushort line_, ushort column, double value) {
    modshogunPINVOKE.DynProg_set_a__SWIG_1(swigCPtr, line_, column, value);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public double get_q(ushort offset) {
    double ret = modshogunPINVOKE.DynProg_get_q(swigCPtr, offset);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double get_q_deriv(ushort offset) {
    double ret = modshogunPINVOKE.DynProg_get_q_deriv(swigCPtr, offset);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double get_p(ushort offset) {
    double ret = modshogunPINVOKE.DynProg_get_p(swigCPtr, offset);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double get_p_deriv(ushort offset) {
    double ret = modshogunPINVOKE.DynProg_get_p_deriv(swigCPtr, offset);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void precompute_content_values() {
    modshogunPINVOKE.DynProg_precompute_content_values(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_double get_lin_feat(SWIGTYPE_p_int dim1, SWIGTYPE_p_int dim2) {
    IntPtr cPtr = modshogunPINVOKE.DynProg_get_lin_feat(swigCPtr, SWIGTYPE_p_int.getCPtr(dim1), SWIGTYPE_p_int.getCPtr(dim2));
    SWIGTYPE_p_double ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_lin_feat(SWIGTYPE_p_double p_lin_feat, int p_num_svms, int p_seq_len) {
    modshogunPINVOKE.DynProg_set_lin_feat(swigCPtr, SWIGTYPE_p_double.getCPtr(p_lin_feat), p_num_svms, p_seq_len);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void create_word_string() {
    modshogunPINVOKE.DynProg_create_word_string(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void precompute_stop_codons() {
    modshogunPINVOKE.DynProg_precompute_stop_codons(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public double get_a(ushort line_, ushort column) {
    double ret = modshogunPINVOKE.DynProg_get_a(swigCPtr, line_, column);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double get_a_deriv(ushort line_, ushort column) {
    double ret = modshogunPINVOKE.DynProg_get_a_deriv(swigCPtr, line_, column);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_intron_list(IntronList intron_list, int num_plifs) {
    modshogunPINVOKE.DynProg_set_intron_list(swigCPtr, IntronList.getCPtr(intron_list), num_plifs);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public SegmentLoss get_segment_loss_object() {
    IntPtr cPtr = modshogunPINVOKE.DynProg_get_segment_loss_object(swigCPtr);
    SegmentLoss ret = (cPtr == IntPtr.Zero) ? null : new SegmentLoss(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void long_transition_settings(bool use_long_transitions, int threshold, int max_len) {
    modshogunPINVOKE.DynProg_long_transition_settings(swigCPtr, use_long_transitions, threshold, max_len);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}
