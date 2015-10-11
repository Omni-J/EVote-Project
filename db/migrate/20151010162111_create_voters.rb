class CreateVoters < ActiveRecord::Migration
  def change
    create_table :voters do |t|
      t.string :egn
      t.integer :vote

      t.timestamps null: false
    end
  end
end
