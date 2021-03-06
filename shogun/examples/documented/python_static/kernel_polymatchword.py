# The PolyMatchWordString kernel is defined on strings of equal length. 
# The kernel sums over the matches of two stings of the same length and 
# takes the sum to the power of 'degree'. The strings in this example 
# consist of the characters 'ACGT' corresponding to the DNA-alphabet. Each 
# column of the matrices of type char corresponds to one training/test example.

from tools.load import LoadMatrix
from sg import sg
lm=LoadMatrix()

traindna=lm.load_dna('../data/fm_train_dna.dat')
testdna=lm.load_dna('../data/fm_test_dna.dat')
trainlabel=lm.load_labels('../data/label_train_dna.dat')
parameter_list=[[traindna,testdna,trainlabel,10,2,True,True,3,0,'n'],
		[traindna,testdna,trainlabel,11,3,True,True,4,0,'n']]

def kernel_polymatchword (fm_train_dna=traindna,fm_test_dna=testdna,
				   label_train_dna=trainlabel,size_cache=10,
				   degree=2,inhomogene=True,normalize=True,
				   order=3,gap=0,reverse='n'):

	sg('add_preproc', 'SORTWORDSTRING')
	sg('set_features', 'TRAIN', fm_train_dna, 'DNA')
	sg('convert', 'TRAIN', 'STRING', 'CHAR', 'STRING', 'WORD', order, order-1, gap, reverse)
	sg('attach_preproc', 'TRAIN')

	sg('set_features', 'TEST', fm_test_dna, 'DNA')
	sg('convert', 'TEST', 'STRING', 'CHAR', 'STRING', 'WORD', order, order-1, gap, reverse)
	sg('attach_preproc', 'TEST')

	sg('set_kernel', 'POLYMATCH', 'WORD', size_cache, degree, inhomogene, normalize)
	km=sg('get_kernel_matrix', 'TRAIN')
	km=sg('get_kernel_matrix', 'TEST')
	return km

if __name__=='__main__':
	print 'PolyMatchWord'
	kernel_polymatchword(*parameter_list[0])
