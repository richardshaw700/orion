FUNCTION: GolfIn::Detection::ClubDetectionBallImpactParams::ClubDetectionBallImpactParams
ENTRY: 180085bb0
REASONS: name:club


/* public: __cdecl
   GolfIn::Detection::ClubDetectionBallImpactParams::ClubDetectionBallImpactParams(enum
   GolfIn::Detection::PlayerHandedness const & __ptr64,class cv::Point_<float> const & __ptr64,class
   cv::Point_<float> const & __ptr64,class cv::Mat const & __ptr64,int,float) __ptr64 */

ClubDetectionBallImpactParams * __thiscall
GolfIn::Detection::ClubDetectionBallImpactParams::ClubDetectionBallImpactParams
          (ClubDetectionBallImpactParams *this,PlayerHandedness *param_1,Point_<float> *param_2,
          Point_<float> *param_3,Mat *param_4,int param_5,float param_6)

{
  Mat *pMVar1;
  Mat local_78 [96];
  
                    /* 0x85bb0  34
                       ??0ClubDetectionBallImpactParams@Detection@GolfIn@@QEAA@AEBW4PlayerHandedness@12@AEBV?$Point_@M@cv@@1AEBVMat@5@HM@Z
                        */
  *(undefined4 *)this = 0;
  *(undefined4 *)(this + 4) = DAT_1801d1160;
  *(undefined4 *)(this + 8) = DAT_1801d1164;
  *(undefined4 *)(this + 0xc) = DAT_1801d1160;
  *(undefined4 *)(this + 0x10) = DAT_1801d1164;
  cv::Mat::Mat((Mat *)(this + 0x18));
  *(undefined4 *)(this + 0x78) = 0xffffffff;
  *(undefined4 *)(this + 0x7c) = 0xbf800000;
  this[0x80] = (ClubDetectionBallImpactParams)0x0;
  *(PlayerHandedness *)this = *param_1;
  *(undefined8 *)(this + 4) = *(undefined8 *)param_2;
  *(undefined8 *)(this + 0xc) = *(undefined8 *)param_3;
  pMVar1 = (Mat *)cv::Mat::clone(param_4);
  cv::Mat::operator=((Mat *)(this + 0x18),pMVar1);
  cv::Mat::~Mat(local_78);
  *(int *)(this + 0x78) = param_5;
  *(float *)(this + 0x7c) = param_6;
  return this;
}

