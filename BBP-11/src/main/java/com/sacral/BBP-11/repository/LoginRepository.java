@Repository
public interface LoginRepository extends JpaRepository<Login, Long> {
    
    List<Login> findByMobileNo(String mobileNo);
    
    Boolean existsByMobileNoAndOtp(String mobileNo, int otp);
}