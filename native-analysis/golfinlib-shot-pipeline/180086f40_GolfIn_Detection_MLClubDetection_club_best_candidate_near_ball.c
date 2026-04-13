FUNCTION: GolfIn::Detection::MLClubDetection::club_best_candidate_near_ball
ENTRY: 180086f40
REASONS: name:club


/* public: struct GolfIn::ClubOutputParams __cdecl
   GolfIn::Detection::MLClubDetection::club_best_candidate_near_ball(class cv::Point_<float> const &
   __ptr64,class std::vector<struct GolfIn::ClubOutputParams,class std::allocator<struct
   GolfIn::ClubOutputParams> > const & __ptr64)const __ptr64 */

Point_<float> * __thiscall
GolfIn::Detection::MLClubDetection::club_best_candidate_near_ball
          (MLClubDetection *this,Point_<float> *param_1,
          vector<struct_GolfIn::ClubOutputParams,class_std::allocator<struct_GolfIn::ClubOutputParams>_>
          *param_2)

{
  undefined8 *puVar1;
  int iVar2;
  int iVar3;
  undefined4 *puVar4;
  undefined8 uVar5;
  double _Y;
  longlong lVar6;
  ulonglong uVar7;
  ulonglong uVar8;
  longlong lVar9;
  longlong lVar10;
  longlong *in_R9;
  double dVar11;
  double dVar12;
  double dVar13;
  
                    /* 0x86f40  453
                       ?club_best_candidate_near_ball@MLClubDetection@Detection@GolfIn@@QEBA?AUClubOutputParams@3@AEBV?$Point_@M@cv@@AEBV?$vector@UClubOutputParams@GolfIn@@V?$allocator@UClubOutputParams@GolfIn@@@std@@@std@@@Z
                        */
  uVar7 = 1;
  puVar4 = (undefined4 *)*in_R9;
  *(undefined4 *)param_1 = *puVar4;
  *(undefined4 *)(param_1 + 4) = puVar4[1];
  uVar5 = *(undefined8 *)(puVar4 + 4);
  *(undefined8 *)(param_1 + 8) = *(undefined8 *)(puVar4 + 2);
  *(undefined8 *)(param_1 + 0x10) = uVar5;
  cv::Mat::Mat((Mat *)(param_1 + 0x18),(Mat *)(puVar4 + 6));
  _Y = DAT_18017ead0;
  lVar10 = *in_R9;
  lVar9 = (in_R9[1] - lVar10) + SUB168(SEXT816(-0x7777777777777777) * SEXT816(in_R9[1] - lVar10),8);
  uVar8 = (lVar9 >> 6) - (lVar9 >> 0x3f);
  if (uVar8 != 1) {
    iVar2 = *(int *)(lVar10 + 0x14);
    iVar3 = *(int *)(lVar10 + 0xc);
    dVar11 = pow((double)((float)(*(int *)(lVar10 + 0x10) / 2 + *(int *)(lVar10 + 8)) -
                         *(float *)param_2),DAT_18017ead0);
    dVar12 = pow((double)((float)(iVar2 / 2 + iVar3) - *(float *)(param_2 + 4)),_Y);
    dVar12 = dVar12 + dVar11;
    if (1 < uVar8) {
      lVar9 = 0x78;
      do {
        iVar2 = *(int *)(lVar9 + 0x14 + lVar10);
        iVar3 = *(int *)(lVar9 + 0xc + lVar10);
        dVar11 = pow((double)((float)(*(int *)(lVar9 + 0x10 + lVar10) / 2 +
                                     *(int *)(lVar9 + 8 + lVar10)) - *(float *)param_2),_Y);
        dVar13 = pow((double)((float)(iVar2 / 2 + iVar3) - *(float *)(param_2 + 4)),_Y);
        if (dVar13 + dVar11 < dVar12) {
          *(undefined4 *)param_1 = *(undefined4 *)(lVar9 + lVar10);
          *(undefined4 *)(param_1 + 4) = *(undefined4 *)(lVar9 + 4 + lVar10);
          puVar1 = (undefined8 *)(lVar9 + 8 + lVar10);
          uVar5 = puVar1[1];
          *(undefined8 *)(param_1 + 8) = *puVar1;
          *(undefined8 *)(param_1 + 0x10) = uVar5;
          cv::Mat::operator=((Mat *)(param_1 + 0x18),(Mat *)(lVar10 + 0x18 + lVar9));
          dVar12 = dVar13 + dVar11;
        }
        uVar7 = uVar7 + 1;
        lVar9 = lVar9 + 0x78;
        lVar10 = *in_R9;
        lVar6 = SUB168(SEXT816(-0x7777777777777777) * SEXT816(in_R9[1] - lVar10),8) +
                (in_R9[1] - lVar10);
      } while (uVar7 < (ulonglong)((lVar6 >> 6) - (lVar6 >> 0x3f)));
    }
  }
  return param_1;
}

