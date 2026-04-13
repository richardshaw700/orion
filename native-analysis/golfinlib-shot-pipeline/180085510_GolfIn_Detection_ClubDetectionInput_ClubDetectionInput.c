FUNCTION: GolfIn::Detection::ClubDetectionInput::ClubDetectionInput
ENTRY: 180085510
REASONS: name:club


/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* public: __cdecl GolfIn::Detection::ClubDetectionInput::ClubDetectionInput(class cv::Mat const &
   __ptr64,class cv::Mat const & __ptr64,class cv::Point_<float> const & __ptr64,int,enum
   GolfIn::Detection::DetectionMethod,int,class std::basic_string<char,struct
   std::char_traits<char>,class std::allocator<char> > const & __ptr64,float,bool,bool) __ptr64 */

ClubDetectionInput * __thiscall
GolfIn::Detection::ClubDetectionInput::ClubDetectionInput
          (ClubDetectionInput *this,Mat *param_1,Mat *param_2,Point_<float> *param_3,int param_4,
          DetectionMethod param_5,int param_6,
          basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *param_7,
          float param_8,bool param_9,bool param_10)

{
  float fVar1;
  undefined8 uVar2;
  Mat *pMVar3;
  undefined8 uVar4;
  Mat local_b8 [128];
  
                    /* 0x85510  37
                       ??0ClubDetectionInput@Detection@GolfIn@@QEAA@AEBVMat@cv@@0AEBV?$Point_@M@4@HW4DetectionMethod@12@HAEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@M_N4@Z
                        */
  *(undefined8 *)this = 0;
  *(undefined8 *)(this + 8) = 0;
  *(undefined8 *)(this + 0x10) = 0;
  *(undefined8 *)(this + 0x18) = 0;
  uVar4 = 0;
  FUN_18000c1d0((undefined8 *)this,&DAT_18016a0f8,0);
  *(undefined4 *)(this + 0x20) = 0xffffffff;
  cv::Mat::Mat((Mat *)(this + 0x28));
  cv::Mat::Mat((Mat *)(this + 0x88));
  *(undefined4 *)(this + 0xe8) = DAT_1801d1160;
  *(undefined4 *)(this + 0xec) = DAT_1801d1164;
  *(undefined4 *)(this + 0xf0) = 0xffffffff;
  uVar2 = _UNK_18016d040;
  *(undefined8 *)(this + 0xf4) = _DAT_18016d038;
  *(undefined8 *)(this + 0xfc) = uVar2;
  *(undefined4 *)(this + 0x104) = 0xbf800000;
  this[0x108] = (ClubDetectionInput)0x0;
  this[0x109] = (ClubDetectionInput)0x0;
  *(undefined4 *)(this + 0x10c) = 1;
  pMVar3 = (Mat *)cv::Mat::clone(param_1);
  cv::Mat::operator=((Mat *)(this + 0x28),pMVar3);
  cv::Mat::~Mat(local_b8);
  pMVar3 = (Mat *)cv::Mat::clone(param_2);
  cv::Mat::operator=((Mat *)(this + 0x88),pMVar3);
  cv::Mat::~Mat(local_b8);
  *(undefined8 *)(this + 0xe8) = *(undefined8 *)param_3;
  *(int *)(this + 0xf0) = param_4;
  fVar1 = *(float *)(param_3 + 4);
  *(int *)(this + 0xf4) = (int)(*(float *)param_3 - (float)(param_4 / 2));
  *(int *)(this + 0xf8) = (int)(fVar1 - (float)(param_4 / 2));
  *(int *)(this + 0xfc) = param_4;
  *(int *)(this + 0x100) = param_4;
  *(DetectionMethod *)(this + 0x10c) = param_5;
  *(int *)(this + 0x20) = param_6;
  FUN_18000c400((longlong *)this,(longlong *)param_7,uVar4);
  *(float *)(this + 0x104) = param_8;
  this[0x108] = (ClubDetectionInput)param_9;
  this[0x109] = (ClubDetectionInput)param_10;
  return this;
}

