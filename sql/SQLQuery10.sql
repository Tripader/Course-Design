create view qianyg_ѧ����ѧ�γ�(ѧ��,�γ̱��,�γ�����,��ʦ���,��ʦ����,ѧ��,�γ�����)
as
select  qianyg_ѧ��.qyg_ѧ��,qianyg_�γ�.qyg_�γ̱��,qianyg_�γ�.qyg_�γ�����,
          qianyg_��ʦ.qyg_��ʦ���,qianyg_��ʦ.qyg_����,
          qianyg_ѡ�����.qyg_ѧ��,qianyg_�γ�.qyg_�γ�����
  from qianyg_ѡ�����,qianyg_�γ�,qianyg_��ʦ,qianyg_ѧ��
  where qianyg_ѧ��.qyg_�༶���=qianyg_ѡ�����.qyg_�༶���
        and qianyg_ѡ�����.qyg_�γ̱��=qianyg_�γ�.qyg_�γ̱��
        and qianyg_ѡ�����.qyg_��ʦ���=qianyg_��ʦ.qyg_��ʦ���
