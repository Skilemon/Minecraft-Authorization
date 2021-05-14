# ----------Start Cloudflare----------
# Update domain record info
curl -X PUT "https://api.cloudflare.com/client/v4/zones/2cdad5347fcf2e7e4f6492236c44bad2/dns_records/d31cd50e9f3ca63f321f123f99f6a2fa" \
     -H "X-Auth-Email: 550645679@qq.com" \
     -H "X-Auth-Key: 084c9dd4acb7f2bba66a4af462ab81188174a" \
     -H "Content-Type: application/json" \
     --data '{"type":"CNAME","name":"mc-wb.blueart.design","content":"mc.svia.ml","ttl":1,"proxied":false}'

# Get domain zone_id
curl -s -X GET "https://api.cloudflare.com/client/v4/zones?name=blueart.design" \
     -H "X-Auth-Email: 550645679@qq.com" \
     -H "X-Auth-Key: 084c9dd4acb7f2bba66a4af462ab81188174a" \
     -H "Content-Type: application/json" | grep -Po '(?<="id":")[^"]*' | head -1

# Get domain record_id
curl -s -X GET "https://api.cloudflare.com/client/v4/zones/2cdad5347fcf2e7e4f6492236c44bad2/dns_records?name=wb-blueart.design&type=CNAME" \
     -H "X-Auth-Email: 550645679@qq.com" \
     -H "X-Auth-Key: 084c9dd4acb7f2bba66a4af462ab81188174a" \
     -H "Content-Type: application/json" | grep -Po '(?<="id":")[^"]*'

# ----------End Cloudflare----------
# ----------Start DNSPod----------
curl -X POST https://dnsapi.cn/Record.Modify \
     -d 'login_token=235372,e920f89d5f40621e4e15ad4d8f8343c9&format=json&domain_id=82917864&record_id=810955568&sub_domain=mc-wb&value=svia.ml&record_type=CNAME&record_line_id=0'
# ----------End DNSPod----------