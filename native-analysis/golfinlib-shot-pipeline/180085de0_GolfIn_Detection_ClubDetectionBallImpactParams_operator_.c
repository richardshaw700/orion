FUNCTION: GolfIn::Detection::ClubDetectionBallImpactParams::operator=
ENTRY: 180085de0
REASONS: name:club


/* public: struct GolfIn::Detection::ClubDetectionBallImpactParams & __ptr64 __cdecl
   GolfIn::Detection::ClubDetectionBallImpactParams::operator=(struct
   GolfIn::Detection::ClubDetectionBallImpactParams && __ptr64) __ptr64 */

ClubDetectionBallImpactParams * __thiscall
GolfIn::Detection::ClubDetectionBallImpactParams::operator=
          (ClubDetectionBallImpactParams *this,ClubDetectionBallImpactParams *param_1)

{
                    /* 0x85de0  102
                       ??4ClubDetectionBallImpactParams@Detection@GolfIn@@QEAAAEAU012@$$QEAU012@@Z
                        */
  *(undefined4 *)this = *(undefined4 *)param_1;
  *(undefined8 *)(this + 4) = *(undefined8 *)(param_1 + 4);
  *(undefined8 *)(this + 0xc) = *(undefined8 *)(param_1 + 0xc);
  cv::Mat::operator=((Mat *)(this + 0x18),(Mat *)(param_1 + 0x18));
  *(undefined4 *)(this + 0x78) = *(undefined4 *)(param_1 + 0x78);
  *(undefined4 *)(this + 0x7c) = *(undefined4 *)(param_1 + 0x7c);
  this[0x80] = param_1[0x80];
  return this;
}

