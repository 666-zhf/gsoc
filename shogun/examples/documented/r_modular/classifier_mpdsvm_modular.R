# In this example a two-class support vector machine classifier is trained on a
# toy data set and the trained classifier is used to predict labels of test
# examples. As training algorithm the Minimal Primal Dual SVM is used with SVM
# regularization parameter C=1 and a Gaussian kernel of width 1.2 and the
# precision parameter 1e-5. 
# 
# For more details on the MPD solver see 
#  Kienzle, W. and B. Sch�lkopf: Training Support Vector Machines with Multiple
#  Equality Constraints. Machine Learning: ECML 2005, 182-193. (Eds.) Carbonell,
#  J. G., J. Siekmann, Springer, Berlin, Germany (11 2005)

library(shogun)

fm_train_real <- t(as.matrix(read.table('../data/fm_train_real.dat')))
fm_test_real <- t(as.matrix(read.table('../data/fm_test_real.dat')))
label_train_multiclass <- as.real(read.table('../data/label_train_multiclass.dat')$V1)

# libsvmmulticlass
print('LibSVMMultiClass')

feats_train <- RealFeatures(fm_train_real)
feats_test <- RealFeatures(fm_test_real)
width <- 2.1
kernel <- GaussianKernel(feats_train, feats_train, width)

C <- 1.2
epsilon <- 1e-5
num_threads <- as.integer(8)
labels <- Labels(label_train_multiclass)

svm <- LibSVMMultiClass(C, kernel, labels)
dump <- svm$set_epsilon(svm, epsilon)
dump <- svm$parallel$set_num_threads(svm$parallel, num_threads)
dump <- svm$train(svm)

dump <- kernel$init(kernel, feats_train, feats_test)
lab <- svm$apply(svm)
out <- lab$get_labels(lab)
