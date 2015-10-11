json.array!(@candidates) do |candidate|
  json.extract! candidate, :id, :number, :name
  json.url candidate_url(candidate, format: :json)
end
