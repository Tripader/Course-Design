create view qianyg_ѧ���ɼ���ͼ(ѧ��,����,רҵ,ѧ��,�ɼ�,��ʦ����,�γ�����)
as
select  distinct qianyg_ѧ��.qyg_ѧ��,qianyg_ѧ��.qyg_����,qianyg_�༶.qyg_רҵ,
          qianyg_ѧ���ɼ�.qyg_ѧ��,qianyg_ѧ���ɼ�.qyg_�ɼ�,
          qianyg_��ʦ.qyg_����,qianyg_�γ�.qyg_�γ�����
  from qianyg_ѧ���ɼ�,qianyg_ѧ��,qianyg_�༶,qianyg_�γ�,qianyg_���ڿγ�,qianyg_��ʦ
  where qianyg_ѧ���ɼ�.qyg_ѧ��=qianyg_ѧ��.qyg_ѧ��
        and qianyg_ѧ��.qyg_�༶���=qianyg_�༶.qyg_�༶���
        and qianyg_ѧ���ɼ�.qyg_�γ̱��=qianyg_�γ�.qyg_�γ̱��
        and qianyg_ѧ���ɼ�.qyg_��ʦ���=qianyg_��ʦ.qyg_��ʦ���
