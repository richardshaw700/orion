FUNCTION: GolfIn::YoloClubSegmentation::letter_box
ENTRY: 18008ef40
REASONS: name:club


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* public: void __cdecl GolfIn::YoloClubSegmentation::letter_box(class cv::Mat const & __ptr64,class
   cv::Mat & __ptr64,class cv::Vec<double,4> & __ptr64,class cv::Size_<int> const &
   __ptr64,bool,bool,bool,int,class cv::Scalar_<double> const & __ptr64) __ptr64 */

void __thiscall
GolfIn::YoloClubSegmentation::letter_box
          (YoloClubSegmentation *this,Mat *param_1,Mat *param_2,Vec<double,4> *param_3,
          Size_<int> *param_4,bool param_5,bool param_6,bool param_7,int param_8,
          Scalar_<double> *param_9)

{
  int iVar1;
  int iVar2;
  int iVar3;
  int iVar4;
  float *pfVar5;
  Mat *pMVar6;
  int iVar7;
  int iVar8;
  float fVar9;
  float fVar10;
  float fVar11;
  float fVar12;
  float fVar13;
  float fVar14;
  undefined1 auStackY_1b8 [32];
  float local_178;
  float local_174;
  float local_170 [2];
  undefined4 local_168 [2];
  Mat *local_160;
  undefined8 local_158;
  undefined4 local_150 [2];
  Mat *local_148;
  undefined8 local_140;
  int local_138;
  int iStack_134;
  Vec<double,4> *local_130;
  Scalar_<double> *local_128;
  Mat local_118 [96];
  float local_b8 [2];
  ulonglong local_b0;
  
                    /* 0x8ef40  760
                       ?letter_box@YoloClubSegmentation@GolfIn@@QEAAXAEBVMat@cv@@AEAV34@AEAV?$Vec@N$03@4@AEBV?$Size_@H@4@_N44HAEBV?$Scalar_@N@4@@Z
                        */
  local_b0 = DAT_1801d1040 ^ (ulonglong)auStackY_1b8;
  local_130 = param_3;
  local_128 = param_9;
  iVar1 = **(int **)(param_1 + 0x40);
  iVar2 = (*(int **)(param_1 + 0x40))[1];
  iVar3 = *(int *)param_4;
  fVar9 = (float)iVar2;
  fVar13 = (float)iVar3 / fVar9;
  local_178 = fVar13;
  iVar4 = *(int *)(param_4 + 4);
  fVar14 = (float)iVar4 / (float)iVar1;
  local_174 = fVar14;
  pfVar5 = &local_178;
  if (fVar14 <= fVar13) {
    pfVar5 = &local_174;
  }
  fVar10 = *pfVar5;
  local_b8[0] = fVar10;
  if (!param_7) {
    local_170[0] = 1.0;
    pfVar5 = local_170;
    if (fVar10 <= DAT_18017e9d8) {
      pfVar5 = local_b8;
    }
    fVar10 = *pfVar5;
  }
  fVar9 = (float)roundf(fVar9 * fVar10);
  iVar7 = (int)fVar9;
  fVar9 = (float)roundf();
  iVar8 = (int)fVar9;
  fVar11 = (float)(iVar3 - iVar7);
  fVar12 = (float)(iVar4 - iVar8);
  fVar9 = fVar10;
  if (param_5) {
    fVar11 = (float)((int)fVar11 % param_8);
    fVar12 = (float)((int)fVar12 % param_8);
  }
  else if (param_6) {
    fVar11 = 0.0;
    fVar12 = 0.0;
    fVar10 = fVar13;
    fVar9 = fVar14;
    iVar7 = iVar3;
    iVar8 = iVar4;
  }
  fVar11 = fVar11 * DAT_18017e97c;
  fVar12 = fVar12 * DAT_18017e97c;
  if ((iVar2 == iVar7) || (iVar1 == iVar8)) {
    pMVar6 = (Mat *)cv::Mat::clone(param_1);
    cv::Mat::operator=(param_2,pMVar6);
    cv::Mat::~Mat(local_118);
  }
  else {
    local_158 = 0;
    local_168[0] = 0x2010000;
    local_140 = 0;
    local_150[0] = 0x1010000;
    local_160 = param_2;
    local_148 = param_1;
    local_138 = iVar7;
    iStack_134 = iVar8;
    cv::resize(local_150,local_168,CONCAT44(iVar8,iVar7));
  }
  fVar13 = DAT_18017e920;
  fVar14 = (float)roundf(fVar12 - DAT_18017e920);
  fVar13 = (float)roundf(fVar11 - fVar13);
  *(double *)local_130 = (double)fVar10;
  *(double *)(local_130 + 8) = (double)fVar9;
  *(double *)(local_130 + 0x10) = (double)(int)fVar13;
  *(double *)(local_130 + 0x18) = (double)(int)fVar14;
  local_140 = 0;
  local_150[0] = 0x2010000;
  local_158 = 0;
  local_168[0] = 0x1010000;
  local_160 = param_2;
  local_148 = param_2;
  fVar9 = (float)roundf();
  fVar10 = (float)roundf();
  cv::copyMakeBorder((_InputArray *)local_168,(_OutputArray *)local_150,(int)fVar14,(int)fVar10,
                     (int)fVar13,(int)fVar9,0,local_128);
  return;
}

