create table qianyg_ѡ�����  (
   qyg_�γ̱��  char(20),
   qyg_�༶���  char(6),
   qyg_��ʦ���  char(20),
   qyg_ѧ�� char(20),
   constraint  PK_ѡ�����  primary  key  (qyg_�γ̱��,qyg_�༶���,qyg_��ʦ���),
   constraint  FK_�γ�_ѡ��  foreign  key  (qyg_�γ̱��) references qianyg_�γ�,
   constraint  FK_�༶_ѡ��  foreign  key  (qyg_�༶���) references qianyg_�༶,
   constraint  FK_��ʦ_ѡ��  foreign  key  (qyg_��ʦ���) references qianyg_��ʦ
   )
