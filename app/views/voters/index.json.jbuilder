json.array!(@voters) do |voter|
  json.extract! voter, :id, :egn, :vote
  json.url voter_url(voter, format: :json)
end
