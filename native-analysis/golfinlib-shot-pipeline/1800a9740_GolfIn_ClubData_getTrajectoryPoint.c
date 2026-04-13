FUNCTION: GolfIn::ClubData::getTrajectoryPoint
ENTRY: 1800a9740
REASONS: name:club


/* public: class cv::Point_<float> __cdecl GolfIn::ClubData::getTrajectoryPoint(float const &
   __ptr64,bool const & __ptr64)const __ptr64 */

float * __thiscall GolfIn::ClubData::getTrajectoryPoint(ClubData *this,float *param_1,bool *param_2)

{
  int iVar1;
  undefined8 uVar2;
  bool bVar3;
  char *in_R9;
  float local_res8;
  float fStackX_c;
  
                    /* 0xa9740  694
                       ?getTrajectoryPoint@ClubData@GolfIn@@QEBA?AV?$Point_@M@cv@@AEBMAEB_N@Z */
  if ((*(longlong *)(this + 0x150) != *(longlong *)(this + 0x158)) &&
     (*(longlong *)(this + 0x168) != *(longlong *)(this + 0x170))) {
    local_res8 = DAT_1801d1200;
    fStackX_c = DAT_1801d1204;
    bVar3 = Libraries::Core::polyFitFindPoint
                      ((vector<float,class_std::allocator<float>_> *)(this + 0x150),
                       (vector<float,class_std::allocator<float>_> *)(this + 0x168),(float *)param_2
                       ,(Point_<float> *)&local_res8);
    if (bVar3) {
      if (*in_R9 == '\0') {
        iVar1 = *(int *)(this + 0xb4);
        *param_1 = local_res8 - (float)*(int *)(this + 0xb0);
        param_1[1] = fStackX_c - (float)iVar1;
        return param_1;
      }
      uVar2 = CONCAT44(fStackX_c,local_res8);
      goto LAB_1800a9804;
    }
  }
  uVar2 = CONCAT44(DAT_1801d1204,DAT_1801d1200);
LAB_1800a9804:
  *(undefined8 *)param_1 = uVar2;
  return param_1;
}

