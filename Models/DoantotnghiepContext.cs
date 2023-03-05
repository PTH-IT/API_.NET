using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API_.NET.Models;

public partial class DoantotnghiepContext : DbContext
{
    public DoantotnghiepContext()
    {
    }

    public DoantotnghiepContext(DbContextOptions<DoantotnghiepContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BaiTap> BaiTaps { get; set; }

    public virtual DbSet<BaiTapTl> BaiTapTls { get; set; }

    public virtual DbSet<BaiTapTn> BaiTapTns { get; set; }

    public virtual DbSet<CauHoi> CauHois { get; set; }

    public virtual DbSet<Chudetailieu> Chudetailieus { get; set; }

    public virtual DbSet<Commentbaitap> Commentbaitaps { get; set; }

    public virtual DbSet<Commentnotification> Commentnotifications { get; set; }

    public virtual DbSet<DapAn> DapAns { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<FileBttl> FileBttls { get; set; }

    public virtual DbSet<FileTb> FileTbs { get; set; }

    public virtual DbSet<KeywordLibrary> KeywordLibraries { get; set; }

    public virtual DbSet<KeywordTailieu> KeywordTailieus { get; set; }

    public virtual DbSet<Loimoi> Loimois { get; set; }

    public virtual DbSet<LopHoc> LopHocs { get; set; }

    public virtual DbSet<Mess> Messes { get; set; }

    public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }

    public virtual DbSet<Plagiarism> Plagiarisms { get; set; }

    public virtual DbSet<Replycomment> Replycomments { get; set; }

    public virtual DbSet<ReplycommentBt> ReplycommentBts { get; set; }

    public virtual DbSet<Sysdiagram> Sysdiagrams { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

    public virtual DbSet<ThanhVienLop> ThanhVienLops { get; set; }

    public virtual DbSet<ThongBao> ThongBaos { get; set; }

    public virtual DbSet<TtbaiTapTl> TtbaiTapTls { get; set; }

    public virtual DbSet<TtbaiTapTn> TtbaiTapTns { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=HAU;Database=DOANTOTNGHIEP;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BaiTap>(entity =>
        {
            entity.HasKey(e => e.MaBaiTap).HasName("PK_dbo.BaiTap");

            entity.ToTable("BaiTap");

            entity.HasIndex(e => e.MaLop, "IX_MaLop");

            entity.Property(e => e.ChuDe).HasMaxLength(2000);
            entity.Property(e => e.LoaiBaiTap).HasMaxLength(20);
            entity.Property(e => e.NguoiTao).HasMaxLength(20);
            entity.Property(e => e.ThoiGianDang).HasColumnType("datetime");
            entity.Property(e => e.ThoiGianKetThuc).HasColumnType("datetime");

            entity.HasOne(d => d.MaLopNavigation).WithMany(p => p.BaiTaps)
                .HasForeignKey(d => d.MaLop)
                .HasConstraintName("FK_dbo.BaiTap_dbo.LopHoc_MaLop");
        });

        modelBuilder.Entity<BaiTapTl>(entity =>
        {
            entity.HasKey(e => e.MaBaiNop).HasName("PK_dbo.BaiTapTL");

            entity.ToTable("BaiTapTL");

            entity.HasIndex(e => e.MaBaiTap, "IX_MaBaiTap");

            entity.HasIndex(e => e.NguoiNop, "IX_NguoiNop");

            entity.Property(e => e.NgayNop).HasColumnType("datetime");
            entity.Property(e => e.NguoiNop).HasMaxLength(20);

            entity.HasOne(d => d.MaBaiTapNavigation).WithMany(p => p.BaiTapTls)
                .HasForeignKey(d => d.MaBaiTap)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.BaiTapTL_dbo.BaiTap_MaBaiTap");

            entity.HasOne(d => d.NguoiNopNavigation).WithMany(p => p.BaiTapTls)
                .HasForeignKey(d => d.NguoiNop)
                .HasConstraintName("FK_dbo.BaiTapTL_dbo.TaiKhoan_NguoiNop");
        });

        modelBuilder.Entity<BaiTapTn>(entity =>
        {
            entity.HasKey(e => e.MaBaiNop).HasName("PK_dbo.BaiTapTN");

            entity.ToTable("BaiTapTN");

            entity.HasIndex(e => e.MaBaiTap, "IX_MaBaiTap");

            entity.HasIndex(e => e.NguoiNop, "IX_NguoiNop");

            entity.Property(e => e.NgayNop).HasColumnType("datetime");
            entity.Property(e => e.NguoiNop).HasMaxLength(20);

            entity.HasOne(d => d.MaBaiTapNavigation).WithMany(p => p.BaiTapTns)
                .HasForeignKey(d => d.MaBaiTap)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.BaiTapTN_dbo.BaiTap_MaBaiTap");

            entity.HasOne(d => d.NguoiNopNavigation).WithMany(p => p.BaiTapTns)
                .HasForeignKey(d => d.NguoiNop)
                .HasConstraintName("FK_dbo.BaiTapTN_dbo.TaiKhoan_NguoiNop");
        });

        modelBuilder.Entity<CauHoi>(entity =>
        {
            entity.HasKey(e => e.MaCauHoi).HasName("PK_dbo.CauHoi");

            entity.ToTable("CauHoi");

            entity.HasIndex(e => e.MaBaiTap, "IX_MaBaiTap");

            entity.Property(e => e.NgayThem).HasColumnType("datetime");

            entity.HasOne(d => d.MaBaiTapNavigation).WithMany(p => p.CauHois)
                .HasForeignKey(d => d.MaBaiTap)
                .HasConstraintName("FK_dbo.CauHoi_dbo.BaiTap_MaBaiTap");
        });

        modelBuilder.Entity<Chudetailieu>(entity =>
        {
            entity.HasKey(e => e.Machude).HasName("PK_dbo.Chudetailieu");

            entity.ToTable("Chudetailieu");
        });

        modelBuilder.Entity<Commentbaitap>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_dbo.commentbaitap");

            entity.ToTable("commentbaitap");

            entity.HasIndex(e => e.MaBaiTap, "IX_MaBaiTap");

            entity.HasIndex(e => e.Nguoidang, "IX_Nguoidang");

            entity.Property(e => e.Nguoidang).HasMaxLength(20);
            entity.Property(e => e.Thoigiandang).HasColumnType("datetime");

            entity.HasOne(d => d.MaBaiTapNavigation).WithMany(p => p.Commentbaitaps)
                .HasForeignKey(d => d.MaBaiTap)
                .HasConstraintName("FK_dbo.commentbaitap_dbo.BaiTap_MaBaiTap");

            entity.HasOne(d => d.NguoidangNavigation).WithMany(p => p.Commentbaitaps)
                .HasForeignKey(d => d.Nguoidang)
                .HasConstraintName("FK_dbo.commentbaitap_dbo.TaiKhoan_Nguoidang");
        });

        modelBuilder.Entity<Commentnotification>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_dbo.commentnotification");

            entity.ToTable("commentnotification");

            entity.HasIndex(e => e.MaThongbao, "IX_MaThongbao");

            entity.HasIndex(e => e.Nguoidang, "IX_Nguoidang");

            entity.Property(e => e.Nguoidang).HasMaxLength(20);
            entity.Property(e => e.Thoigiandang).HasColumnType("datetime");

            entity.HasOne(d => d.MaThongbaoNavigation).WithMany(p => p.Commentnotifications)
                .HasForeignKey(d => d.MaThongbao)
                .HasConstraintName("FK_dbo.commentnotification_dbo.ThongBao_MaThongbao");

            entity.HasOne(d => d.NguoidangNavigation).WithMany(p => p.Commentnotifications)
                .HasForeignKey(d => d.Nguoidang)
                .HasConstraintName("FK_dbo.commentnotification_dbo.TaiKhoan_Nguoidang");
        });

        modelBuilder.Entity<DapAn>(entity =>
        {
            entity.HasKey(e => e.MaDapAn).HasName("PK_dbo.DapAn");

            entity.ToTable("DapAn");

            entity.HasIndex(e => e.MaCauHoi, "IX_MaCauHoi");

            entity.HasOne(d => d.MaCauHoiNavigation).WithMany(p => p.DapAns)
                .HasForeignKey(d => d.MaCauHoi)
                .HasConstraintName("FK_dbo.DapAn_dbo.CauHoi_MaCauHoi");
        });

        modelBuilder.Entity<Document>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_dbo.document");

            entity.ToTable("document");

            entity.HasIndex(e => e.MaLop, "IX_MaLop");

            entity.HasIndex(e => e.Machude, "IX_Machude");

            entity.HasIndex(e => e.Nguoisohuu, "IX_Nguoisohuu");

            entity.Property(e => e.Ngaydang).HasColumnType("datetime");
            entity.Property(e => e.Nguoisohuu).HasMaxLength(20);

            entity.HasOne(d => d.MaLopNavigation).WithMany(p => p.Documents)
                .HasForeignKey(d => d.MaLop)
                .HasConstraintName("FK_dbo.document_dbo.LopHoc_MaLop");

            entity.HasOne(d => d.MachudeNavigation).WithMany(p => p.Documents)
                .HasForeignKey(d => d.Machude)
                .HasConstraintName("FK_dbo.document_dbo.Chudetailieu_Machude");

            entity.HasOne(d => d.NguoisohuuNavigation).WithMany(p => p.Documents)
                .HasForeignKey(d => d.Nguoisohuu)
                .HasConstraintName("FK_dbo.document_dbo.TaiKhoan_Nguoisohuu");
        });

        modelBuilder.Entity<FileBttl>(entity =>
        {
            entity.HasKey(e => e.Mafile).HasName("PK_dbo.FileBTTL");

            entity.ToTable("FileBTTL");

            entity.HasIndex(e => e.MaBt, "IX_MaBt");

            entity.Property(e => e.TenFile).HasMaxLength(200);

            entity.HasOne(d => d.MaBtNavigation).WithMany(p => p.FileBttls)
                .HasForeignKey(d => d.MaBt)
                .HasConstraintName("FK_dbo.FileBTTL_dbo.BaiTap_MaBt");
        });

        modelBuilder.Entity<FileTb>(entity =>
        {
            entity.HasKey(e => e.Mafile).HasName("PK_dbo.FileTB");

            entity.ToTable("FileTB");

            entity.HasIndex(e => e.MaTb, "IX_maTB");

            entity.Property(e => e.MaTb).HasColumnName("maTB");
            entity.Property(e => e.NoiLuu).HasMaxLength(200);

            entity.HasOne(d => d.MaTbNavigation).WithMany(p => p.FileTbs)
                .HasForeignKey(d => d.MaTb)
                .HasConstraintName("FK_dbo.FileTB_dbo.ThongBao_maTB");
        });

        modelBuilder.Entity<KeywordLibrary>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_dbo.KeywordLibrary");

            entity.ToTable("KeywordLibrary");
        });

        modelBuilder.Entity<KeywordTailieu>(entity =>
        {
            entity.HasKey(e => e.MaKeyword).HasName("PK_dbo.KeywordTailieu");

            entity.ToTable("KeywordTailieu");

            entity.HasIndex(e => e.Machude, "IX_Machude");

            entity.HasOne(d => d.MachudeNavigation).WithMany(p => p.KeywordTailieus)
                .HasForeignKey(d => d.Machude)
                .HasConstraintName("FK_dbo.KeywordTailieu_dbo.Chudetailieu_Machude");
        });

        modelBuilder.Entity<Loimoi>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_dbo.Loimoi");

            entity.ToTable("Loimoi");

            entity.HasIndex(e => e.MaLop, "IX_MaLop");

            entity.HasIndex(e => e.TenDangNhap, "IX_TenDangNhap");

            entity.Property(e => e.Ma).HasColumnName("ma");
            entity.Property(e => e.TenDangNhap).HasMaxLength(20);

            entity.HasOne(d => d.MaLopNavigation).WithMany(p => p.Loimois)
                .HasForeignKey(d => d.MaLop)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Loimoi_dbo.LopHoc_MaLop");

            entity.HasOne(d => d.TenDangNhapNavigation).WithMany(p => p.Loimois)
                .HasForeignKey(d => d.TenDangNhap)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Loimoi_dbo.TaiKhoan_TenDangNhap");
        });

        modelBuilder.Entity<LopHoc>(entity =>
        {
            entity.HasKey(e => e.MaLop).HasName("PK_dbo.LopHoc");

            entity.ToTable("LopHoc");

            entity.HasIndex(e => e.NguoiTao, "IX_NguoiTao");

            entity.Property(e => e.NgayTao).HasColumnType("datetime");
            entity.Property(e => e.NguoiTao).HasMaxLength(20);
            entity.Property(e => e.TenLop).HasMaxLength(2000);

            entity.HasOne(d => d.NguoiTaoNavigation).WithMany(p => p.LopHocs)
                .HasForeignKey(d => d.NguoiTao)
                .HasConstraintName("FK_dbo.LopHoc_dbo.TaiKhoan_NguoiTao");
        });

        modelBuilder.Entity<Mess>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_dbo.Mess");

            entity.ToTable("Mess");

            entity.HasIndex(e => e.NguoiGui, "IX_NguoiGui");

            entity.HasIndex(e => e.NguoiNhan, "IX_NguoiNhan");

            entity.HasIndex(e => e.Malop, "IX_malop");

            entity.Property(e => e.Malop).HasColumnName("malop");
            entity.Property(e => e.NguoiGui).HasMaxLength(20);
            entity.Property(e => e.NguoiNhan).HasMaxLength(20);
            entity.Property(e => e.Thoigiangui)
                .HasColumnType("datetime")
                .HasColumnName("thoigiangui");

            entity.HasOne(d => d.MalopNavigation).WithMany(p => p.Messes)
                .HasForeignKey(d => d.Malop)
                .HasConstraintName("FK_dbo.Mess_dbo.LopHoc_malop");

            entity.HasOne(d => d.NguoiGuiNavigation).WithMany(p => p.MessNguoiGuiNavigations)
                .HasForeignKey(d => d.NguoiGui)
                .HasConstraintName("FK_dbo.Mess_dbo.TaiKhoan_NguoiGui");

            entity.HasOne(d => d.NguoiNhanNavigation).WithMany(p => p.MessNguoiNhanNavigations)
                .HasForeignKey(d => d.NguoiNhan)
                .HasConstraintName("FK_dbo.Mess_dbo.TaiKhoan_NguoiNhan");
        });

        modelBuilder.Entity<MigrationHistory>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.ContextKey }).HasName("PK_dbo.__MigrationHistory");

            entity.ToTable("__MigrationHistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ContextKey).HasMaxLength(300);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<Plagiarism>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_dbo.Plagiarism");

            entity.ToTable("Plagiarism");

            entity.HasIndex(e => e.Mafile, "IX_Mafile");

            entity.HasOne(d => d.MafileNavigation).WithMany(p => p.Plagiarisms)
                .HasForeignKey(d => d.Mafile)
                .HasConstraintName("FK_dbo.Plagiarism_dbo.TTBaiTapTL_Mafile");
        });

        modelBuilder.Entity<Replycomment>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_dbo.replycomment");

            entity.ToTable("replycomment");

            entity.HasIndex(e => e.Macomment, "IX_Macomment");

            entity.HasIndex(e => e.Nguoidang, "IX_Nguoidang");

            entity.Property(e => e.Nguoidang).HasMaxLength(20);
            entity.Property(e => e.Thoigiandang).HasColumnType("datetime");

            entity.HasOne(d => d.MacommentNavigation).WithMany(p => p.Replycomments)
                .HasForeignKey(d => d.Macomment)
                .HasConstraintName("FK_dbo.replycomment_dbo.commentnotification_Macomment");

            entity.HasOne(d => d.NguoidangNavigation).WithMany(p => p.Replycomments)
                .HasForeignKey(d => d.Nguoidang)
                .HasConstraintName("FK_dbo.replycomment_dbo.TaiKhoan_Nguoidang");
        });

        modelBuilder.Entity<ReplycommentBt>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_dbo.replycommentBT");

            entity.ToTable("replycommentBT");

            entity.HasIndex(e => e.MaComment, "IX_MaComment");

            entity.HasIndex(e => e.Nguoidang, "IX_Nguoidang");

            entity.Property(e => e.Nguoidang).HasMaxLength(20);
            entity.Property(e => e.Thoigiandang).HasColumnType("datetime");

            entity.HasOne(d => d.MaCommentNavigation).WithMany(p => p.ReplycommentBts)
                .HasForeignKey(d => d.MaComment)
                .HasConstraintName("FK_dbo.replycommentBT_dbo.commentbaitap_MaComment");

            entity.HasOne(d => d.NguoidangNavigation).WithMany(p => p.ReplycommentBts)
                .HasForeignKey(d => d.Nguoidang)
                .HasConstraintName("FK_dbo.replycommentBT_dbo.TaiKhoan_Nguoidang");
        });

        modelBuilder.Entity<Sysdiagram>(entity =>
        {
            entity.HasKey(e => e.DiagramId).HasName("PK_dbo.sysdiagrams");

            entity.ToTable("sysdiagrams");

            entity.Property(e => e.DiagramId).HasColumnName("diagram_id");
            entity.Property(e => e.Definition).HasColumnName("definition");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
            entity.Property(e => e.PrincipalId).HasColumnName("principal_id");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.HasKey(e => e.TenDangNhap).HasName("PK_dbo.TaiKhoan");

            entity.ToTable("TaiKhoan");

            entity.Property(e => e.TenDangNhap).HasMaxLength(20);
            entity.Property(e => e.ChucVu).HasMaxLength(20);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.HinhAnh).HasMaxLength(200);
            entity.Property(e => e.Ho).HasMaxLength(50);
            entity.Property(e => e.MatKhau).HasMaxLength(1000);
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.Token).HasColumnName("token");
        });

        modelBuilder.Entity<ThanhVienLop>(entity =>
        {
            entity.HasKey(e => new { e.MaLop, e.Mathanhvien }).HasName("PK_dbo.ThanhVienLop");

            entity.ToTable("ThanhVienLop");

            entity.HasIndex(e => e.MaLop, "IX_MaLop");

            entity.HasIndex(e => e.Mathanhvien, "IX_Mathanhvien");

            entity.Property(e => e.Mathanhvien).HasMaxLength(20);
            entity.Property(e => e.ChucVu).HasMaxLength(20);
            entity.Property(e => e.NgayThamGia).HasColumnType("datetime");

            entity.HasOne(d => d.MaLopNavigation).WithMany(p => p.ThanhVienLops)
                .HasForeignKey(d => d.MaLop)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.ThanhVienLop_dbo.LopHoc_MaLop");

            entity.HasOne(d => d.MathanhvienNavigation).WithMany(p => p.ThanhVienLops)
                .HasForeignKey(d => d.Mathanhvien)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.ThanhVienLop_dbo.TaiKhoan_Mathanhvien");
        });

        modelBuilder.Entity<ThongBao>(entity =>
        {
            entity.HasKey(e => e.MaBaiDang).HasName("PK_dbo.ThongBao");

            entity.ToTable("ThongBao");

            entity.HasIndex(e => e.MaBaiTap, "IX_MaBaiTap");

            entity.HasIndex(e => e.MaLop, "IX_MaLop");

            entity.HasIndex(e => e.NguoiDang, "IX_NguoiDang");

            entity.Property(e => e.LoaiThongBao).HasMaxLength(20);
            entity.Property(e => e.NgayDang).HasColumnType("datetime");
            entity.Property(e => e.NguoiDang).HasMaxLength(20);

            entity.HasOne(d => d.MaBaiTapNavigation).WithMany(p => p.ThongBaos)
                .HasForeignKey(d => d.MaBaiTap)
                .HasConstraintName("FK_dbo.ThongBao_dbo.BaiTap_MaBaiTap");

            entity.HasOne(d => d.MaLopNavigation).WithMany(p => p.ThongBaos)
                .HasForeignKey(d => d.MaLop)
                .HasConstraintName("FK_dbo.ThongBao_dbo.LopHoc_MaLop");

            entity.HasOne(d => d.NguoiDangNavigation).WithMany(p => p.ThongBaos)
                .HasForeignKey(d => d.NguoiDang)
                .HasConstraintName("FK_dbo.ThongBao_dbo.TaiKhoan_NguoiDang");
        });

        modelBuilder.Entity<TtbaiTapTl>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_dbo.TTBaiTapTL");

            entity.ToTable("TTBaiTapTL");

            entity.HasIndex(e => e.MaBaiNop, "IX_MaBaiNop");

            entity.HasIndex(e => e.Machude, "IX_Machude");

            entity.HasIndex(e => e.NguoiNop, "IX_NguoiNop");

            entity.Property(e => e.NgayNop).HasColumnType("datetime");
            entity.Property(e => e.NguoiNop).HasMaxLength(20);
            entity.Property(e => e.NoiLuu).HasMaxLength(100);
            entity.Property(e => e.Tenfile).HasMaxLength(200);

            entity.HasOne(d => d.MaBaiNopNavigation).WithMany(p => p.TtbaiTapTls)
                .HasForeignKey(d => d.MaBaiNop)
                .HasConstraintName("FK_dbo.TTBaiTapTL_dbo.BaiTapTL_MaBaiNop");

            entity.HasOne(d => d.MachudeNavigation).WithMany(p => p.TtbaiTapTls)
                .HasForeignKey(d => d.Machude)
                .HasConstraintName("FK_dbo.TTBaiTapTL_dbo.Chudetailieu_Machude");

            entity.HasOne(d => d.NguoiNopNavigation).WithMany(p => p.TtbaiTapTls)
                .HasForeignKey(d => d.NguoiNop)
                .HasConstraintName("FK_dbo.TTBaiTapTL_dbo.TaiKhoan_NguoiNop");
        });

        modelBuilder.Entity<TtbaiTapTn>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_dbo.TTBaiTapTN");

            entity.ToTable("TTBaiTapTN");

            entity.HasIndex(e => e.MaBaiNop, "IX_MaBaiNop");

            entity.HasIndex(e => e.MaCauHoi, "IX_MaCauHoi");

            entity.HasIndex(e => e.MaDapAnluaChon, "IX_MaDapAnluaChon");

            entity.HasIndex(e => e.NguoiNop, "IX_NguoiNop");

            entity.Property(e => e.NguoiNop).HasMaxLength(20);

            entity.HasOne(d => d.MaBaiNopNavigation).WithMany(p => p.TtbaiTapTns)
                .HasForeignKey(d => d.MaBaiNop)
                .HasConstraintName("FK_dbo.TTBaiTapTN_dbo.BaiTapTN_MaBaiNop");

            entity.HasOne(d => d.MaCauHoiNavigation).WithMany(p => p.TtbaiTapTns)
                .HasForeignKey(d => d.MaCauHoi)
                .HasConstraintName("FK_dbo.TTBaiTapTN_dbo.CauHoi_MaCauHoi");

            entity.HasOne(d => d.MaDapAnluaChonNavigation).WithMany(p => p.TtbaiTapTns)
                .HasForeignKey(d => d.MaDapAnluaChon)
                .HasConstraintName("FK_dbo.TTBaiTapTN_dbo.DapAn_MaDapAnluaChon");

            entity.HasOne(d => d.NguoiNopNavigation).WithMany(p => p.TtbaiTapTns)
                .HasForeignKey(d => d.NguoiNop)
                .HasConstraintName("FK_dbo.TTBaiTapTN_dbo.TaiKhoan_NguoiNop");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
