class Voter < ActiveRecord::Base
  validates :egn, presence: true, uniqueness: true, length: { is: 10 }
end
