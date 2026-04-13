FUNCTION: GolfIn::Detection::ClubDetectionBallImpactParams::ClubDetectionBallImpactParams
ENTRY: 180085cc0
REASONS: name:club


/* public: __cdecl
   GolfIn::Detection::ClubDetectionBallImpactParams::ClubDetectionBallImpactParams(struct
   GolfIn::Detection::ClubDetectionBallImpactParams const & __ptr64) __ptr64 */

ClubDetectionBallImpactParams * __thiscall
GolfIn::Detection::ClubDetectionBallImpactParams::ClubDetectionBallImpactParams
          (ClubDetectionBallImpactParams *this,ClubDetectionBallImpactParams *param_1)

{
                    /* 0x85cc0  33
                       ??0ClubDetectionBallImpactParams@Detection@GolfIn@@QEAA@AEBU012@@Z */
  *(undefined4 *)this = *(undefined4 *)param_1;
  *(undefined8 *)(this + 4) = *(undefined8 *)(param_1 + 4);
  *(undefined8 *)(this + 0xc) = *(undefined8 *)(param_1 + 0xc);
  cv::Mat::Mat((Mat *)(this + 0x18),(Mat *)(param_1 + 0x18));
  *(undefined4 *)(this + 0x78) = *(undefined4 *)(param_1 + 0x78);
  *(undefined4 *)(this + 0x7c) = *(undefined4 *)(param_1 + 0x7c);
  this[0x80] = param_1[0x80];
  return this;
}

